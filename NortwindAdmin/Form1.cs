using Domain.Services;

namespace NortwindAdmin
{
    public partial class Form1 : Form
    {
        private readonly ProductService _productService;

        public Form1(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var products = await _productService.GetProducts();

            dataGridView1.DataSource = products;
        }
    }
}