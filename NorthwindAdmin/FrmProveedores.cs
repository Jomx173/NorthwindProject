using Domain.Models.DTO;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using NortwindAdmin;
using System;
using System.Windows.Forms;

namespace NorthwindAdmin
{
    public partial class FrmProveedores : Form
    {
        private readonly SupplierService _service;
        private readonly ProductService _productService;
        private readonly ReportService _reportService;
        private readonly VentasEmpleadosServices _ventasEmpleadosServices;

        public FrmProveedores(SupplierService service, ProductService productService)
        {
            InitializeComponent();
            _service = service;
            _productService = productService;
        }

        private async void FrmProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.DataSource = await _service.GetSuppliers();
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                dgvProveedores.DataSource = await _service.GetSuppliers();
                return;
            }

            var proveedor = await _service.GetSupplierById(id);

            if (proveedor == null)
            {
                MessageBox.Show("Proveedor no encontrado.");
                return;
            }

            dgvProveedores.DataSource = new List<SupplierDto>
            {
                proveedor
            };
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtCompanyName.Clear();
            txtContactName.Clear();
            txtCountry.Clear();
            txtPhone.Clear();
        }

        private async void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Ingrese el nombre de la empresa.");
                return;
            }

            SupplierDto proveedor = new SupplierDto
            {
                CompanyName = txtCompanyName.Text.Trim(),
                ContactName = txtContactName.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };

            await _service.AddSupplier(proveedor);

            MessageBox.Show("Proveedor registrado correctamente.");

            dgvProveedores.DataSource = await _service.GetSuppliers();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Seleccione un proveedor.");
                return;
            }

            SupplierDto proveedor = new SupplierDto
            {
                SupplierId = id,
                CompanyName = txtCompanyName.Text.Trim(),
                ContactName = txtContactName.Text.Trim(),
                Country = txtCountry.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };

            await _service.UpdateSupplier(proveedor);

            MessageBox.Show("Proveedor actualizado correctamente.");

            dgvProveedores.DataSource = await _service.GetSuppliers();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id))
            {
                MessageBox.Show("Seleccione un proveedor.");
                return;
            }

            if (MessageBox.Show("¿Desea eliminar este proveedor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            await _service.DeleteSupplier(id);

            MessageBox.Show("Proveedor eliminado correctamente.");

            dgvProveedores.DataSource = await _service.GetSuppliers();
        }

        private async void dgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvProveedores.CurrentRow == null)
                return;

            SupplierDto proveedor =
                (SupplierDto)dgvProveedores.CurrentRow.DataBoundItem;

            txtId.Text = proveedor.SupplierId.ToString();
            txtCompanyName.Text = proveedor.CompanyName;
            txtContactName.Text = proveedor.ContactName ?? "";
            txtCountry.Text = proveedor.Country ?? "";
            txtPhone.Text = proveedor.Phone ?? "";

            MessageBox.Show("Proveedor: " + proveedor.SupplierId);

            dgvProductos.DataSource =
                await _productService.GetProductsBySupplier(proveedor.SupplierId);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm =
            Program.ServiceProvider.GetRequiredService<FrmMenuPrincipal>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmMenuGestiones frm =
            Program.ServiceProvider.GetRequiredService<FrmMenuGestiones>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmInventario frm =
            Program.ServiceProvider.GetRequiredService<FrmInventario>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuReportes frm = new FrmMenuReportes(
            _reportService, _ventasEmpleadosServices);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDashboard frm =
            Program.ServiceProvider.GetRequiredService<FrmDashboard>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "¿Desea salir del sistema?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
