using Domain.Models.DTO;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwinAdmin
{
    public partial class FrmEmpleados : Form
    {
        private readonly EmployeesServices _employeesServices;


        public FrmEmpleados(EmployeesServices employeesServices)
        {
            InitializeComponent();
            _employeesServices = employeesServices;
            EstilizarTablas();

            dgvEmpleados.CellClick += dgvEmpleados_CellClick;
            btnAgregar.Click += btnAgregar_Click;
            btnModificar.Click += btnModificar_Click;
            txtFirstName.KeyPress += SoloLetras_KeyPress;
            txtLastName.KeyPress += SoloLetras_KeyPress;

        }


        private async void FrmEmpleados_Load(object sender, EventArgs e)
        {
            await CargarListaEmpleados();
        }

        private async Task CargarListaEmpleados()
        {
            try
            {
                var empleados = await _employeesServices.GetEmployees();

                dgvEmpleados.DataSource = null;
                dgvEmpleados.DataSource = empleados;
                dgvEmpleados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar la lista de empleados: {ex.Message}",
                                "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                
                txtFirstName.Text = dgvEmpleados.Rows[e.RowIndex].Cells["FirstName"].Value?.ToString();
                txtLastName.Text = dgvEmpleados.Rows[e.RowIndex].Cells["LastName"].Value?.ToString();
                txtHomePhone.Text = dgvEmpleados.Rows[e.RowIndex].Cells["HomePhone"].Value?.ToString();
                txtAddress.Text = dgvEmpleados.Rows[e.RowIndex].Cells["Address"].Value?.ToString();
                try
                {

                    var idEmpleadoStr = dgvEmpleados.Rows[e.RowIndex].Cells["EmployeesID"].Value?.ToString();

                    if (!string.IsNullOrEmpty(idEmpleadoStr))
                    {

                        List<OrderDto> pedidos = await _employeesServices.GetOrdersByEmployee(idEmpleadoStr);


                        dgvPedidos.DataSource = null;
                        dgvPedidos.DataSource = pedidos;
                        dgvPedidos.Refresh();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los pedidos de este empleado: {ex.Message}",
                                    "Error de Detalle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void EstilizarTablas()
        {
            
            System.Drawing.Color azulOscuro = System.Drawing.Color.FromArgb(31, 41, 112);
            
            System.Drawing.Color azulSeleccion = System.Drawing.Color.FromArgb(0, 122, 204);
           
            System.Drawing.Color grisClaro = System.Drawing.Color.FromArgb(245, 247, 250);

            DataGridView[] tablas = { dgvEmpleados, dgvPedidos };

            foreach (var dgv in tablas)
            {
                if (dgv == null) continue;

                
                dgv.BackgroundColor = System.Drawing.Color.White;
                dgv.BorderStyle = BorderStyle.None;
                dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.MultiSelect = false;
                dgv.AllowUserToResizeRows = false;
                dgv.RowHeadersVisible = false; 

               
                dgv.EnableHeadersVisualStyles = false;

               
                dgv.ColumnHeadersHeight = 40;
                dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = azulOscuro;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
                dgv.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                
                dgv.RowTemplate.Height = 35;
                dgv.DefaultCellStyle.BackColor = System.Drawing.Color.White;
                dgv.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51);
                dgv.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
                dgv.DefaultCellStyle.SelectionBackColor = azulSeleccion;
                dgv.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                
                dgv.AlternatingRowsDefaultCellStyle.BackColor = grisClaro;

                
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

      
        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               
                var nuevoEmp = new EmployeesDto
                {
                 
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    HomePhone = txtHomePhone.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                bool exito = await _employeesServices.AddEmployee(nuevoEmp);

                if (exito)
                {
                    MessageBox.Show("¡Empleado registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    await CargarListaEmpleados(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar: {ex.Message}", "Validación / Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        
        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmpleados.CurrentRow == null)
                {
                    MessageBox.Show("Por favor, selecciona un empleado de la lista primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                var idSeleccionado = dgvEmpleados.CurrentRow.Cells["EmployeesID"].Value?.ToString();

                var empModificado = new EmployeesDto
                {
                    EmployeesID = idSeleccionado,
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    HomePhone = txtHomePhone.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                bool exito = await _employeesServices.UpdateEmployee(empModificado);

                if (exito)
                {
                    MessageBox.Show("¡Datos del empleado actualizados!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    await CargarListaEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void LimpiarCampos()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtHomePhone.Clear();
            txtAddress.Clear();
        }

        private void SoloLetras_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                
                e.Handled = false;
            }
           
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
               
                e.Handled = true;
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}