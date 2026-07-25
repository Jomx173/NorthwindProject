using Domain.Models.DTO;
using Domain.Services;

namespace NorthwindAdmin
{
    public partial class FrmProductos : Form
    {
        // Servicio encargado de los productos
        private readonly ProductService _productService;

        // Servicio encargado de las categorías
        private readonly CategoryService _categoryService;

        // Indica si el formulario aún está cargando datos
        private bool _cargando = true;

        public FrmProductos(ProductService productService,
                            CategoryService categoryService)
        {
            InitializeComponent();

            _productService = productService;
            _categoryService = categoryService;

        }


        // Carga los productos y las categorías al iniciar el formulario
        private async void Form1_Load(object sender, EventArgs e)
        {
            // Obtiene todos los productos
            var products = await _productService.GetProducts();
            dataGridView1.DataSource = products;
            DarFormatoTabla();

            // Obtiene la lista de categorías
            var categories = await _categoryService.GetCategories();

            // Carga las categorías en el ComboBox
            cmbCategorias.DataSource = categories;
            cmbCategorias.DisplayMember = "CategoryName";
            cmbCategorias.ValueMember = "CategoryId";

            // Ya terminó de cargar el formulario
            _cargando = false;
        }
        private void txtIdProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // Busca un producto por su ID
        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                MessageBox.Show(
                    "Ingrese el ID del producto.",
                    "Campo requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdProducto.Focus();
                return;
            }

            // Validar que solo sean números
            if (!int.TryParse(txtIdProducto.Text, out int productId))
            {
                MessageBox.Show(
                    "El ID del producto solo puede contener números.",
                    "Dato inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtIdProducto.SelectAll();
                txtIdProducto.Focus();
                return;
            }

            // Buscar el producto
            var producto = await _productService.GetProductById(productId);

            if (producto != null)
            {
                dataGridView1.DataSource = new List<ProductDto>
        {
            producto
        };

                DarFormatoTabla();
            }
            else
            {
                MessageBox.Show(
                    "Producto no encontrado.",
                    "Búsqueda",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private async void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            var products = await _productService.GetProducts();

            dataGridView1.DataSource = products;
            DarFormatoTabla();
        }


        private async void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            int productId = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["ProductId"].Value);

            var producto = await _productService.GetProductById(productId);

            if (producto != null)
            {
                FrmProductoDetalle frm =
                    new FrmProductoDetalle(producto, _productService);

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    dataGridView1.DataSource =
                        await _productService.GetProducts();
                }
            }
        }


        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmProductoDetalle frm =
                new FrmProductoDetalle(_productService);

            if (frm.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.DataSource =
                    await _productService.GetProducts();
            }
        }

        // Elimina el producto seleccionado
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Seleccione un producto");
                return;
            }

            int productId = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["ProductId"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                await _productService.DeleteProduct(productId);

                MessageBox.Show("Producto eliminado correctamente");

                dataGridView1.DataSource =
                    await _productService.GetProducts();
            }
        }

        private async void cmbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evita ejecutar el filtro mientras el formulario está cargando
            if (_cargando)
                return;

            if (cmbCategorias.SelectedItem == null)
                return;

            CategoryDto categoria = (CategoryDto)cmbCategorias.SelectedItem;

            var products = await _productService.GetProductsByCategory(categoria.CategoryId);

            dataGridView1.DataSource = products;


            DarFormatoTabla();
        }

        private void DarFormatoTabla()
        {
            //AutoScaleDimensions = new SizeF(10F, 25F);
            //AutoScaleMode = AutoScaleMode.Font;
            //Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            //ClientSize = new Size(1132, 678);



            // BOTÓN BUSCAR
            btnBuscar.BackColor = Color.FromArgb(25, 25, 111);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.Font = new Font("Nirmala UI", 10, FontStyle.Bold);

            // BOTÓN MOSTRAR TODOS
            btnMostrarTodos.BackColor = Color.FromArgb(25, 25, 111);
            btnMostrarTodos.ForeColor = Color.White;
            btnMostrarTodos.FlatStyle = FlatStyle.Flat;
            btnMostrarTodos.FlatAppearance.BorderSize = 0;
            btnMostrarTodos.Font = new Font("Nirmala UI", 10, FontStyle.Bold);

            // BOTÓN AGREGAR
            btnAgregar.BackColor = Color.FromArgb(30, 120, 200);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.Font = new Font("Nirmala UI", 10, FontStyle.Bold);

            // BOTÓN EDITAR
            btnEditar.BackColor = Color.FromArgb(30, 120, 200);
            btnEditar.ForeColor = Color.White;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.Font = new Font("Nirmala UI", 10, FontStyle.Bold);

            // BOTÓN ELIMINAR
            btnEliminar.BackColor = Color.FromArgb(178, 34, 34);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Font = new Font("Nirmala UI", 10, FontStyle.Bold);

            // TABLA
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.FromArgb(221, 221, 221);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowHeadersVisible = false;

            // ENCABEZADOS
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 111);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Nirmala UI", 10, FontStyle.Bold);

            // FILAS
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(47, 79, 79);
            dataGridView1.DefaultCellStyle.Font =
                new Font("Nirmala UI", 10);

            // FILAS ALTERNAS
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            // CONFIGURACIÓN
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.ReadOnly = true;

            // COLUMNAS
            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.Columns["ProductId"].HeaderText = "ID";
                dataGridView1.Columns["ProductName"].HeaderText = "Nombre";
                dataGridView1.Columns["UnitPrice"].HeaderText = "Precio";
                dataGridView1.Columns["UnitsInStock"].HeaderText = "Stock";

                dataGridView1.Columns["UnitsOnOrder"].Visible = false;
                dataGridView1.Columns["ReorderLevel"].Visible = false;
                dataGridView1.Columns["SupplierId"].Visible = false;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}