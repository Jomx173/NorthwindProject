using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using NortwindAdmin;

namespace NorthwindAdmin
{
    public partial class FrmMenuPrincipal : Form
    {
        private readonly ReportService _reportService;
        private readonly VentasEmpleadosServices _ventasEmpleadosServices;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMenuReportes frm = new FrmMenuReportes(
           _reportService, _ventasEmpleadosServices);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnGestiones_Click(object sender, EventArgs e)
        {
            FrmMenuGestiones frm =
            Program.ServiceProvider.GetRequiredService<FrmMenuGestiones>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }
    }
}
