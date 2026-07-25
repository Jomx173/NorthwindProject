using Domain.Models.DTO;
using Domain.Services;
using System;
using System.Windows.Forms;

namespace NorthwindAdmin
{
    public partial class FrmProveedores : Form
    {
        private readonly SupplierService _service;
        private readonly ProductService _productService;

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

        }
    }
}
