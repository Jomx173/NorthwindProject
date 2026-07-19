using Domain.Models.DTO;
using Domain.Services;

namespace NorthwindAdmin
{
    public partial class FrmProductoDetalle : Form
    {
        private ProductDto _producto;
        private readonly ProductService _productService;

        // Constructor para editar un producto
        public FrmProductoDetalle(ProductDto producto, ProductService productService)
        {
            InitializeComponent();

            _producto = producto;
            _productService = productService;
        }

        // Constructor para agregar un nuevo producto
        public FrmProductoDetalle(ProductService productService)
        {
            InitializeComponent();
            txtNombre.MaxLength = 40;
            txtPrecio.MaxLength = 10;
            txtStock.MaxLength = 5;

            _productService = productService;
            _producto = new ProductDto();
        }

        // Carga los datos cuando se edita un producto 
        private void FrmProductoDetalle_Load(object sender, EventArgs e)
        {
            if (_producto.ProductId > 0)
            {
                txtIdProducto.Text = _producto.ProductId.ToString();
                txtNombre.Text = _producto.ProductName;
                txtPrecio.Text = _producto.UnitPrice.ToString();
                txtStock.Text = _producto.UnitsInStock.ToString();

                // El ID no se puede modificar
                txtIdProducto.ReadOnly = true;
            }
            else
            {
                // Cuando es un producto nuevo
                txtIdProducto.Clear();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtStock.Clear();

                txtIdProducto.ReadOnly = true;
            }
        }

        // Guarda los cambios o agrega un nuevo producto
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre del producto.",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtNombre.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingrese un precio válido.",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor que cero.",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtPrecio.Focus();
                return;
            }

            if (!short.TryParse(txtStock.Text, out short stock))
            {
                MessageBox.Show("Ingrese un stock válido.",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            if (stock < 0)
            {
                MessageBox.Show("El stock no puede ser negativo.",
                                "Validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                txtStock.Focus();
                return;
            }

            _producto.ProductName = txtNombre.Text.Trim();
            _producto.UnitPrice = precio;
            _producto.UnitsInStock = stock;

            if (_producto.ProductId == 0)
            {
                await _productService.AddProduct(_producto);

                MessageBox.Show("Producto agregado correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                await _productService.UpdateProduct(_producto);

                MessageBox.Show("Producto actualizado correctamente.",
                                "Éxito",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            DialogResult = DialogResult.OK;
            Close();
        }   

        // Cierra el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsLetterOrDigit(e.KeyChar) &&
                !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar) &&
                e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && txtPrecio.Text.Contains("."))
            {
                e.Handled = true;
            }
        }
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) &&
                !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}