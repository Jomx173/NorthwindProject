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

namespace NorthwindAdmin
{
    public partial class FrmMenuReportes : Form
    {
        private ReportService _reportService;

        public FrmMenuReportes(ReportService reportService)
        {
            InitializeComponent();
            _reportService = reportService;
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
            new FrmSalesByCustomerReport(_reportService);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
