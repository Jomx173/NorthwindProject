using System;
using System.Windows.Forms;
using Domain;
using MiCategoria = Domain.Category;

namespace NorthwindAdmin
{
    public partial class FrmCategorias : Form
    {
        private readonly CategoryService _service;

        public FrmCategorias()
        {
            InitializeComponent();
            _service = new CategoryService();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            CargarCategorias();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            ProcesarGuardado();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ProcesarGuardado();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Por favor, seleccione una categoría de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea eliminar esta categoría?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txtId.Text);
                string respuesta = _service.EliminarCategoria(id);

                if (respuesta == "OK")
                {
                    MessageBox.Show("Categoría eliminada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarCategorias();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show(respuesta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCategorias.CurrentRow != null)
            {
                var categoria = dgvCategorias.CurrentRow.DataBoundItem as Domain.Category;

                if (categoria != null)
                {
                    txtId.Text = categoria.CategoryID.ToString();
                    txtNombre.Text = categoria.CategoryName;
                    txtDescription.Text = categoria.Description; // Corregido: antes decía txtDescripcion

                    // Cargar productos asociados
                    dgvProductos.DataSource = _service.ListarProductosPorCategoria(categoria.CategoryID);
                    AjustarColumnasProductos();
                }
            }
        }

        private void CargarCategorias()
        {
            try
            {
                dgvCategorias.DataSource = _service.ListarCategorias();
                AjustarColumnasCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AjustarColumnasCategorias()
        {
            if (dgvCategorias.Columns.Count > 0)
            {
                dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

                if (dgvCategorias.Columns.Contains("CategoryID")) dgvCategorias.Columns["CategoryID"].Width = 90;
                if (dgvCategorias.Columns.Contains("CategoryName")) dgvCategorias.Columns["CategoryName"].Width = 150;

                if (dgvCategorias.Columns.Contains("Description"))
                {
                    dgvCategorias.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void AjustarColumnasProductos()
        {
            if (dgvProductos.Columns.Count > 0)
            {
                dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                if (dgvProductos.Columns.Contains("Id")) dgvProductos.Columns["Id"].Width = 60;
                if (dgvProductos.Columns.Contains("Precio")) dgvProductos.Columns["Precio"].Width = 90;
                if (dgvProductos.Columns.Contains("Stock")) dgvProductos.Columns["Stock"].Width = 70;

                if (dgvProductos.Columns.Contains("Nombre"))
                {
                    dgvProductos.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void ProcesarGuardado()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la categoría es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevaCat = new MiCategoria
            {
                CategoryID = string.IsNullOrEmpty(txtId.Text) ? 0 : Convert.ToInt32(txtId.Text),
                CategoryName = txtNombre.Text.Trim(),
                Description = txtDescription.Text.Trim()
            };

            string respuesta = _service.GuardarCategoria(nuevaCat);

            if (respuesta == "OK")
            {
                MessageBox.Show("¡Categoría procesada con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show(respuesta, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtDescription.Clear();
            dgvProductos.DataSource = null;
            if (dgvCategorias.Rows.Count > 0)
            {
                dgvCategorias.ClearSelection();
            }
        }
    }
}