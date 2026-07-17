using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NorthwinAdmin
{
    public partial class FrmMenuGestiones : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public FrmMenuGestiones()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            var frm = Program.ServiceProvider.GetRequiredService<FrmEmpleados>();
            frm.Show();
            this.Hide();
        }

        private void FrmMenuGestiones_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           
        }
    }
}
