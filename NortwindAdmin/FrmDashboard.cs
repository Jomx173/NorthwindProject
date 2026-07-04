using System;
using System.Drawing;
using System.Windows.Forms;
using DataAccess.Context;
using DataAccess.Repository;
using Domain.Services;

namespace NortwindAdmin
{
    public partial class FrmDashboard : Form
    {
        private readonly DashboardService _dashboardService;
        private readonly OrderService _orderService;

        public FrmDashboard()
        {
            InitializeComponent();

            var context = new NorthwindContext();

            var dashboardRepository = new DashboardRepository(context);
            _dashboardService = new DashboardService(dashboardRepository);

            var orderRepository = new OrderRepository(context);
            _orderService = new OrderService(orderRepository);
        }

        private async void FrmDashboard_Load(object sender, EventArgs e)
        {
            lblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");

            var resumen = await _dashboardService.GetDashboardSummary();

            lblClientes.Text = resumen.TotalClientes.ToString();
            lblEmpleados.Text = resumen.TotalEmpleados.ToString();
            lblProductos.Text = resumen.TotalProductos.ToString();
            lblOrdenes.Text = resumen.TotalOrdenes.ToString();
            lblVentas.Text = resumen.TotalVentas.ToString("C2");

            var ordenes = await _orderService.GetOrders();

            dgvOrdenes.DataSource = ordenes;
            dgvOrdenes.ReadOnly = true;

            // Encabezados
            dgvOrdenes.Columns["OrderID"].HeaderText = "N° Orden";
            dgvOrdenes.Columns["CustomerName"].HeaderText = "Cliente";
            dgvOrdenes.Columns["EmployeeName"].HeaderText = "Empleado";
            dgvOrdenes.Columns["OrderDate"].HeaderText = "Fecha";
            dgvOrdenes.Columns["Total"].HeaderText = "Total";
            dgvOrdenes.Columns["Total"].DefaultCellStyle.Format = "C2";

            // Diseño del DataGridView
            dgvOrdenes.BackgroundColor = Color.White;
            dgvOrdenes.BorderStyle = BorderStyle.None;
            dgvOrdenes.GridColor = Color.FromArgb(221, 221, 221);

            dgvOrdenes.EnableHeadersVisualStyles = false;
            dgvOrdenes.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 111);
            dgvOrdenes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvOrdenes.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvOrdenes.ColumnHeadersHeight = 35;

            dgvOrdenes.DefaultCellStyle.BackColor = Color.White;
            dgvOrdenes.DefaultCellStyle.ForeColor = Color.FromArgb(47, 79, 79);
            dgvOrdenes.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            dgvOrdenes.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvOrdenes.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvOrdenes.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            dgvOrdenes.RowHeadersVisible = false;
            dgvOrdenes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrdenes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Gráfico Ventas por Empleado
            var ventasEmpleado = await _dashboardService.GetVentasPorEmpleado();

            chartVentasEmpleado.Series.Clear();
            chartVentasEmpleado.ChartAreas.Clear();
            chartVentasEmpleado.Legends.Clear();

            var area = new System.Windows.Forms.DataVisualization.Charting.ChartArea("AreaVentas");
            chartVentasEmpleado.ChartAreas.Add(area);

            var legend = new System.Windows.Forms.DataVisualization.Charting.Legend("Leyenda");
            chartVentasEmpleado.Legends.Add(legend);

            var serie = new System.Windows.Forms.DataVisualization.Charting.Series("Ventas");
            serie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            serie.ChartArea = "AreaVentas";
            serie.Legend = "Leyenda";
            serie.Label = "#PERCENT{P0}";
            serie.LegendText = "#VALX";

            foreach (var item in ventasEmpleado)
            {
                serie.Points.AddXY(item.Empleado, item.TotalVentas);
            }

            chartVentasEmpleado.Series.Add(serie);

            // Gráfico Productos más vendidos
            var productos = await _dashboardService.GetProductosMasVendidos();

            chartProductosVendidos.Series.Clear();
            chartProductosVendidos.ChartAreas.Clear();

            chartProductosVendidos.ChartAreas.Add(
                new System.Windows.Forms.DataVisualization.Charting.ChartArea("AreaProductos"));

            var serieProductos = chartProductosVendidos.Series.Add("Productos");
            serieProductos.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            serieProductos.Label = "#PERCENT{P0}";
            serieProductos.LegendText = "#VALX";

            foreach (var item in productos)
            {
                serieProductos.Points.AddXY(item.Producto, item.Cantidad);
            }
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
    }
}