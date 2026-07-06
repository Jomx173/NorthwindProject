using System;
using System.Windows.Forms;
using ProyectoProveedores;
using MiProveedor = Domain.Supplier;

namespace NorthwindAdmin
{
    public partial class Form1 : Form
    {
        private readonly SupplierServices _supplierServices;

        public Form1()
        {
            InitializeComponent();

            var repository = new SupplierRepository();
            _supplierServices = new SupplierServices(repository);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuscarPorPais("USA");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("Por favor, escribe un país para realizar la filtración.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BuscarPorPais(txtPais.Text.Trim());
        }

        private void BuscarPorPais(string pais)
        {
            try
            {
                var proveedores = _supplierServices.FiltrarProveedoresPorPais(pais);
                dgvProveedores.DataSource = proveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpresa.Text))
            {
                MessageBox.Show("El nombre de la empresa es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevo = new MiProveedor
            {
                CompanyName = txtEmpresa.Text.Trim(),
                ContactName = txtContacto.Text.Trim(),
                Country = txtPais.Text.Trim(),
                Phone = txtTelefono.Text.Trim()
            };

            string mensaje = _supplierServices.Registrar(nuevo);
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BuscarPorPais(txtPais.Text.Trim());
            LimpiarCamposFormulario();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Por favor, selecciona primero un proveedor de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var modificado = new MiProveedor
            {
                SupplierID = int.Parse(txtId.Text),
                CompanyName = txtEmpresa.Text.Trim(),
                ContactName = txtContacto.Text.Trim(),
                Country = txtPais.Text.Trim(),
                Phone = txtTelefono.Text.Trim()
            };

            string mensaje = _supplierServices.Actualizar(modificado);
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BuscarPorPais(txtPais.Text.Trim());
            LimpiarCamposFormulario();
        }

        private void DgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                txtId.Text = fila.Cells["SupplierID"].Value?.ToString() ?? "";
                txtEmpresa.Text = fila.Cells["CompanyName"].Value?.ToString() ?? "";
                txtContacto.Text = fila.Cells["ContactName"].Value?.ToString() ?? "";
                txtPais.Text = fila.Cells["Country"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Phone"].Value?.ToString() ?? "";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposFormulario();
        }

        private void LimpiarCamposFormulario()
        {
            txtId.Clear();
            txtEmpresa.Clear();
            txtContacto.Clear();
            txtPais.Clear();
            txtTelefono.Clear();
        }
    }
}