using System;
using System.Windows.Forms;

namespace NorthwindAdmin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias frm = new FrmCategorias();
            frm.ShowDialog(); // Abre las categorías como una ventana emergente limpia
        }
    }
}