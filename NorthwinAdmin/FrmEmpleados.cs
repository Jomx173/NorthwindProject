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


            dgvEmpleados.CellClick += dgvEmpleados_CellClick;

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

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}