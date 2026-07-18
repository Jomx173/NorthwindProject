using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Models.DTO;

namespace NorthwindAdmin
{
    public partial class FrmCategorias : Form
    {
        private readonly CategoryService _service;

        public FrmCategorias(CategoryService service)
        {
            InitializeComponent();
            _service = service;
        }

        private async void FrmCategorias_Load(object sender, EventArgs e)
        {
            await CargarCategorias();
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            await CargarCategorias();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private async void BtnRegistrar_Click(object sender, EventArgs e)
        {
            await GuardarCategoria();
        }

        private async void BtnActualizar_Click(object sender, EventArgs e)
        {
            await GuardarCategoria();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
                return;

            if (await _service.DeleteCategory(Convert.ToInt32(txtId.Text)))
            {
                await CargarCategorias();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No fue posible eliminar la categoría.");
            }
        }

        private async Task CargarCategorias()
        {
            dgvCategorias.DataSource = await _service.ListarCategorias();
            dgvProductos.DataSource = null;
        }

        private async Task GuardarCategoria()
        {
            var dto = new CategoryDto
            {
                CategoryId = string.IsNullOrWhiteSpace(txtId.Text)
                    ? 0
                    : Convert.ToInt32(txtId.Text),
                CategoryName = txtNombre.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };

            bool ok = dto.CategoryId == 0
                ? await _service.CreateCategory(dto)
                : await _service.UpdateCategory(dto);

            if (ok)
            {
                await CargarCategorias();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("No fue posible guardar la categoría.");
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvCategorias.CurrentRow == null)
                return;

            if (dgvCategorias.CurrentRow.DataBoundItem is CategoryDto categoria)
            {
                txtId.Text = categoria.CategoryId.ToString();
                txtNombre.Text = categoria.CategoryName;
                txtDescription.Text = categoria.Description;
                dgvProductos.DataSource = null;
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescription.Clear();
            dgvProductos.DataSource = null;
        }
    }
}
