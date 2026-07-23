


using Domain.Models.DTO;



using Domain.Services;



using System;



using System.Collections.Generic;



using System.Threading.Tasks;



using System.Windows.Forms;







namespace NorthwindAdmin



{



    public partial class FrmCategorias : Form



    {



        private readonly CategoryService _service;
        private readonly ProductService _productService;







        public FrmCategorias(CategoryService service, ProductService productService)
        {
            InitializeComponent();
            _service = service;
            _productService = productService;
        }







        private async void FrmCategorias_Load(object sender, EventArgs e)



        {



            await CargarCategorias();



        }







        private async Task CargarCategorias()



        {



            dgvCategorias.DataSource = await _service.GetCategories();



        }







        private void LimpiarCampos()



        {



            txtId.Clear();



            txtNombre.Clear();



            txtDescription.Clear();



            dgvProductos.DataSource = null;



            dgvCategorias.ClearSelection();



        }







        private async void BtnBuscar_Click(object sender, EventArgs e)



        {



            if (string.IsNullOrWhiteSpace(txtId.Text))



            {



                await CargarCategorias();



                return;



            }







            if (!int.TryParse(txtId.Text, out int id))



            {



                MessageBox.Show("Ingrese un ID válido.");



                return;



            }







            var categoria = await _service.GetCategoryById(id);







            if (categoria == null)



            {



                MessageBox.Show("Categoría no encontrada.");



                return;



            }







            dgvCategorias.DataSource = new List<CategoryDto>



            {



                categoria



            };



        }







        private void BtnLimpiar_Click(object sender, EventArgs e)



        {



            LimpiarCampos();



        }



        private async void BtnRegistrar_Click(object sender, EventArgs e)



        {



            if (string.IsNullOrWhiteSpace(txtNombre.Text))



            {



                MessageBox.Show("Ingrese el nombre de la categoría.");



                return;



            }







            CategoryDto categoria = new CategoryDto



            {



                CategoryName = txtNombre.Text.Trim(),



                Description = txtDescription.Text.Trim()



            };







            await _service.AddCategory(categoria);







            MessageBox.Show("Categoría registrada correctamente.");







            await CargarCategorias();



            LimpiarCampos();



        }







        private async void BtnActualizar_Click(object sender, EventArgs e)



        {



            if (!int.TryParse(txtId.Text, out int id))



            {



                MessageBox.Show("Seleccione una categoría.");



                return;



            }







            CategoryDto categoria = new CategoryDto



            {



                CategoryId = id,



                CategoryName = txtNombre.Text.Trim(),



                Description = txtDescription.Text.Trim()



            };







            await _service.UpdateCategory(categoria);







            MessageBox.Show("Categoría actualizada correctamente.");







            await CargarCategorias();



            LimpiarCampos();



        }







        private async void BtnEliminar_Click(object sender, EventArgs e)



        {



            if (!int.TryParse(txtId.Text, out int id))



            {



                MessageBox.Show("Seleccione una categoría.");



                return;



            }







            DialogResult r = MessageBox.Show(



                "¿Desea eliminar esta categoría?",



                "Confirmar",



                MessageBoxButtons.YesNo,



                MessageBoxIcon.Question);







            if (r != DialogResult.Yes)



                return;







            await _service.DeleteCategory(id);







            MessageBox.Show("Categoría eliminada.");







            await CargarCategorias();



            LimpiarCampos();



        } 

        private async void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)

        {

            if (e.RowIndex < 0 || dgvCategorias.CurrentRow == null)

                return;



            CategoryDto categoria =

                (CategoryDto)dgvCategorias.CurrentRow.DataBoundItem;



            txtId.Text = categoria.CategoryId.ToString();

            txtNombre.Text = categoria.CategoryName;

            txtDescription.Text = categoria.Description;



            dgvProductos.DataSource = await _productService.GetProductsByCategory(categoria.CategoryId);

        }


    }


}

