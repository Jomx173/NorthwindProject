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
            Form1 frm =
        _serviceProvider.GetRequiredService<Form1>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            Hide();
        }
    }
}
