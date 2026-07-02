using Domain.Models.DTO;
using Domain.Services;

namespace NortwindAdmin
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
            _producto.ProductName = txtNombre.Text;
            _producto.UnitPrice = decimal.Parse(txtPrecio.Text);
            _producto.UnitsInStock = short.Parse(txtStock.Text);

            if (_producto.ProductId == 0)
            {
                await _productService.AddProduct(_producto);

                MessageBox.Show("Producto agregado correctamente");
            }
            else
            {
                await _productService.UpdateProduct(_producto);

                MessageBox.Show("Producto actualizado correctamente");
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Cierra el formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}