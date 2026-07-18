using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace NorthwindAdmin
{
    public partial class FrmMenuReportes : Form
    {
        private readonly ReportService _reportService;
        private readonly VentasEmpleadosServices _ventasEmpleadosServices;

        public FrmMenuReportes(ReportService reportService, VentasEmpleadosServices ventasEmpleadosServices)
        {
            InitializeComponent();
            _reportService = reportService;
            _ventasEmpleadosServices = ventasEmpleadosServices;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmMenuReportes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmSalesByCustomerReport frm =
            Program.ServiceProvider.GetRequiredService<FrmSalesByCustomerReport>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmVentasEmpleados frm =
            new FrmVentasEmpleados(_ventasEmpleadosServices);

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
    }
}
