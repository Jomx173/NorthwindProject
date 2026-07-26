using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using NortwindAdmin;
using System;
using System.Windows.Forms;

namespace NorthwindAdmin
{
    public partial class FrmInventario : Form
    {
        private readonly ProductService _productService;
        private readonly ReportService _reportService;
        private readonly VentasEmpleadosServices _ventasEmpleadosServices;

        public FrmInventario(ProductService productService)
        {
            InitializeComponent();

            _productService = productService;

            Load += FrmInventario_Load;
        }

        private async void FrmInventario_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource =
                await _productService.GetProducts();

            DarFormatoTabla();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource =
                await _productService.GetProducts();

            DarFormatoTabla();
        }

        private async void btnLowStock_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource =
                await _productService.GetLowStockProducts((int)numericUpDown1.Value);

            DarFormatoTabla();
        }

        private async void btnOutOfStock_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource =
                await _productService.GetOutOfStockProducts();

            DarFormatoTabla();
        }

        private async void btnTopSelling_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource =
                await _productService.GetTopSellingProducts((int)numericUpDown2.Value);

            DarFormatoTabla();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DarFormatoTabla()
        {
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.BorderStyle = BorderStyle.None;
            dgvProducts.GridColor = Color.FromArgb(221, 221, 221);

            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.RowHeadersVisible = false;

            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(25, 25, 111);

            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            dgvProducts.ColumnHeadersDefaultCellStyle.Font =
                new Font("Nirmala UI", 10, FontStyle.Bold);

            dgvProducts.DefaultCellStyle.Font =
                new Font("Nirmala UI", 10);

            dgvProducts.DefaultCellStyle.BackColor = Color.White;

            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvProducts.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.MultiSelect = false;
            dgvProducts.ReadOnly = true;
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvProducts.Columns.Count > 0)
            {
                if (dgvProducts.Columns.Contains("ProductId"))
                    dgvProducts.Columns["ProductId"].HeaderText = "ID";

                if (dgvProducts.Columns.Contains("ProductName"))
                    dgvProducts.Columns["ProductName"].HeaderText = "Nombre";

                if (dgvProducts.Columns.Contains("UnitPrice"))
                    dgvProducts.Columns["UnitPrice"].HeaderText = "Precio";

                if (dgvProducts.Columns.Contains("UnitsInStock"))
                    dgvProducts.Columns["UnitsInStock"].HeaderText = "Stock";

                if (dgvProducts.Columns.Contains("UnitsOnOrder"))
                    dgvProducts.Columns["UnitsOnOrder"].Visible = false;

                if (dgvProducts.Columns.Contains("ReorderLevel"))
                    dgvProducts.Columns["ReorderLevel"].Visible = false;

                if (dgvProducts.Columns.Contains("SupplierId"))
                    dgvProducts.Columns["SupplierId"].Visible = false;

                if (dgvProducts.Columns.Contains("CategoryId"))
                    dgvProducts.Columns["CategoryId"].Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm =
            Program.ServiceProvider.GetRequiredService<FrmMenuPrincipal>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenuGestiones frm =
            Program.ServiceProvider.GetRequiredService<FrmMenuGestiones>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmInventario frm =
            Program.ServiceProvider.GetRequiredService<FrmInventario>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMenuReportes frm = new FrmMenuReportes(
            _reportService, _ventasEmpleadosServices);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm =
            Program.ServiceProvider.GetRequiredService<FrmDashboard>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "¿Desea salir del sistema?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmMenuGestiones frm =
            Program.ServiceProvider.GetRequiredService<FrmMenuGestiones>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }
    }
}