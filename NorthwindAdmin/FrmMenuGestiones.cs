using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NorthwindAdmin
{
    public partial class FrmMenuGestiones : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public FrmMenuGestiones(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmEmpleados frm =
                _serviceProvider.GetRequiredService<FrmEmpleados>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos frm =
                _serviceProvider.GetRequiredService<FrmProductos>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmInventario frm =
                _serviceProvider.GetRequiredService<FrmInventario>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            Hide();
        }

        private void FrmMenuGestiones_Load(object sender, EventArgs e)
        {

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frm =
      _serviceProvider.GetRequiredService<FrmClientes>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmCategorias frm =
                _serviceProvider.GetRequiredService<FrmCategorias>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmProveedores frm =
                _serviceProvider.GetRequiredService<FrmProveedores>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm =
                Program.ServiceProvider.GetRequiredService<FrmMenuPrincipal>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }
    }
}
