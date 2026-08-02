using DataAccess.Context;
using DataAccess.Repository;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using NorthwindAdmin;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace NortwindAdmin
{
    public partial class FrmDashboard : Form
    {
        private readonly DashboardService _dashboardService;
        private readonly OrderService _orderService;

        public FrmDashboard()
        {
            InitializeComponent();

            var context = new NorthWindContext();

            var dashboardRepository = new DashboardRepository(context);
            _dashboardService = new DashboardService(dashboardRepository);

            var orderRepository = new OrderRepository(context);
            _orderService = new OrderService(orderRepository);
        }

        private async void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblFecha.Text =
                "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            var resumen =
                await _dashboardService.GetDashboardSummary();

            lblClientes.Text =
                resumen.TotalClientes.ToString();

            lblEmpleados.Text =
                resumen.TotalEmpleados.ToString();

            lblProductos.Text =
                resumen.TotalProductos.ToString();

            lblOrdenes.Text =
                resumen.TotalOrdenes.ToString();

            lblVentas.Text =
                resumen.TotalVentas.ToString("C2");

           
            var ordenes =
                await _orderService.GetOrders();

            dgvOrdenes.DataSource = ordenes;

            ConfigurarDataGridViewOrdenes();

           
            var ventasEmpleado =
                await _dashboardService.GetVentasPorEmpleado();

            chartVentasEmpleado.Series.Clear();
            chartVentasEmpleado.ChartAreas.Clear();
            chartVentasEmpleado.Legends.Clear();

            var area =
                new System.Windows.Forms.DataVisualization
                    .Charting.ChartArea("AreaVentas");

            chartVentasEmpleado.ChartAreas.Add(area);

            var legend =
                new System.Windows.Forms.DataVisualization
                    .Charting.Legend("Leyenda");

            chartVentasEmpleado.Legends.Add(legend);

            var serie =
                new System.Windows.Forms.DataVisualization
                    .Charting.Series("Ventas");

            serie.ChartType =
                System.Windows.Forms.DataVisualization
                    .Charting.SeriesChartType.Pie;

            serie.ChartArea = "AreaVentas";
            serie.Legend = "Leyenda";
            serie.Label = "#PERCENT{P0}";
            serie.LegendText = "#VALX";

            foreach (var item in ventasEmpleado)
            {
                serie.Points.AddXY(
                    item.Empleado,
                    item.TotalVentas
                );
            }

            chartVentasEmpleado.Series.Add(serie);

            
            var productos =
                await _dashboardService.GetProductosMasVendidos();

            chartProductosVendidos.Series.Clear();
            chartProductosVendidos.ChartAreas.Clear();
            chartProductosVendidos.Legends.Clear();

            var areaProductos =
                new System.Windows.Forms.DataVisualization
                    .Charting.ChartArea("AreaProductos");

            chartProductosVendidos.ChartAreas.Add(areaProductos);

            var serieProductos =
                chartProductosVendidos.Series.Add("Productos");

            serieProductos.ChartType =
                System.Windows.Forms.DataVisualization
                    .Charting.SeriesChartType.Pie;

            serieProductos.Label = "#PERCENT{P0}";
            serieProductos.LegendText = "#VALX";

            foreach (var item in productos)
            {
                serieProductos.Points.AddXY(
                    item.Producto,
                    item.Cantidad
                );
            }
        }

        private void ConfigurarDataGridViewOrdenes()
        {
            dgvOrdenes.ReadOnly = true;
            dgvOrdenes.AllowUserToAddRows = false;
            dgvOrdenes.AllowUserToDeleteRows = false;
            dgvOrdenes.AllowUserToResizeRows = false;
            dgvOrdenes.RowHeadersVisible = false;
            dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            
            foreach (DataGridViewColumn columna in dgvOrdenes.Columns)
            {
                columna.Visible = false;
            }

    
            if (dgvOrdenes.Columns["OrderId"] != null)
            {
                dgvOrdenes.Columns["OrderId"].Visible = true;
                dgvOrdenes.Columns["OrderId"].HeaderText = "N° Orden";
                dgvOrdenes.Columns["OrderId"].DisplayIndex = 0;
                dgvOrdenes.Columns["OrderId"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

            // Cliente
            if (dgvOrdenes.Columns["CustomerName"] != null)
            {
                dgvOrdenes.Columns["CustomerName"].Visible = true;
                dgvOrdenes.Columns["CustomerName"].HeaderText = "Cliente";
                dgvOrdenes.Columns["CustomerName"].DisplayIndex = 1;
            }

            if (dgvOrdenes.Columns["EmployeeName"] != null)
            {
                dgvOrdenes.Columns["EmployeeName"].Visible = true;
                dgvOrdenes.Columns["EmployeeName"].HeaderText = "Empleado";
                dgvOrdenes.Columns["EmployeeName"].DisplayIndex = 2;
            }

           
            if (dgvOrdenes.Columns["OrderDate"] != null)
            {
                dgvOrdenes.Columns["OrderDate"].Visible = true;
                dgvOrdenes.Columns["OrderDate"].HeaderText = "Fecha";
                dgvOrdenes.Columns["OrderDate"].DisplayIndex = 3;
                dgvOrdenes.Columns["OrderDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvOrdenes.Columns["OrderDate"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
            }

           
            if (dgvOrdenes.Columns["Total"] != null)
            {
                dgvOrdenes.Columns["Total"].Visible = true;
                dgvOrdenes.Columns["Total"].HeaderText = "Total";
                dgvOrdenes.Columns["Total"].DisplayIndex = 4;
                dgvOrdenes.Columns["Total"].DefaultCellStyle.Format = "C2";
                dgvOrdenes.Columns["Total"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;
            }

           
            dgvOrdenes.BackgroundColor = Color.White;
            dgvOrdenes.BorderStyle = BorderStyle.None;
            dgvOrdenes.GridColor = Color.FromArgb(221, 221, 221);

            dgvOrdenes.EnableHeadersVisualStyles = false;
            dgvOrdenes.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(25, 25, 111);
            dgvOrdenes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrdenes.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);
            dgvOrdenes.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
            dgvOrdenes.ColumnHeadersHeight = 35;

            dgvOrdenes.DefaultCellStyle.BackColor = Color.White;
            dgvOrdenes.DefaultCellStyle.ForeColor =
                Color.FromArgb(47, 79, 79);
            dgvOrdenes.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(0, 120, 215);
            dgvOrdenes.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvOrdenes.DefaultCellStyle.Font =
                new Font("Segoe UI", 10);

            dgvOrdenes.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(245, 245, 245);

            dgvOrdenes.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrdenes.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblEmpleados_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm =
                Program.ServiceProvider
                    .GetRequiredService<FrmMenuPrincipal>();

            frm.StartPosition =
                FormStartPosition.CenterScreen;

            frm.Show();
            Hide();
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            FrmMenuReportes frm =
                Program.ServiceProvider
                    .GetRequiredService<FrmMenuReportes>();

            frm.StartPosition =
                FormStartPosition.CenterScreen;

            frm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenuGestiones frm =
                Program.ServiceProvider
                    .GetRequiredService<FrmMenuGestiones>();

            frm.StartPosition =
                FormStartPosition.CenterScreen;

            frm.Show();
            Hide();
        }

        private void btncontroles_Click(object sender, EventArgs e)
        {
            FrmInventario frm =
           Program.ServiceProvider.GetRequiredService<FrmInventario>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult respuesta =
                MessageBox.Show(
                    "¿Está seguro de que desea cerrar el proyecto?",
                    "Cerrar proyecto",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}