using System;
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
            var resumen = await _dashboardService.GetDashboardSummary();

            lblClientes.Text = resumen.TotalClientes.ToString();
            lblEmpleados.Text = resumen.TotalEmpleados.ToString();
            lblProductos.Text = resumen.TotalProductos.ToString();
            lblOrdenes.Text = resumen.TotalOrdenes.ToString();
            lblVentas.Text = resumen.TotalVentas.ToString("C2");

            var ordenes = await _orderService.GetOrders();

            dgvOrdenes.DataSource = ordenes;
            dgvOrdenes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrdenes.ReadOnly = true;


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

            foreach (var item in ventasEmpleado)
            {
                serie.Points.AddXY(item.Empleado, item.TotalVentas);
            }

            foreach (var punto in serie.Points)
            {
                punto.Label = "#PERCENT{P0}";
            }

            chartVentasEmpleado.Series.Add(serie);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
        }

        private void lblEmpleados_Click(object sender, EventArgs e)
        {
        }
    }
}