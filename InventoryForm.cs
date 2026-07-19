csharp NortwindAdmin\InventoryForm.Designer.cs
using System.Windows.Forms;
using System.Drawing;

namespace NortwindAdmin
{
    partial class InventoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvProducts;
        private Button btnRefresh;
        private Button btnLowStock;
        private Button btnOutOfStock;
        private Button btnTopSelling;
        private NumericUpDown nudThreshold;
        private NumericUpDown nudTopN;
        private Panel panelIzquierdo;
        private Button btnInicio;
        private Button btnGestiones;
        private Button btnControles;
        private Button btnReportes;
        private Button btnDashboard;
        private Button btnCerrarSesion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgvProducts = new DataGridView();
            btnRefresh = new Button();
            btnLowStock = new Button();
            btnOutOfStock = new Button();
            btnTopSelling = new Button();
            nudThreshold = new NumericUpDown();
            nudTopN = new NumericUpDown();
            panelIzquierdo = new Panel();
            btnInicio = new Button();
            btnGestiones = new Button();
            btnControles = new Button();
            btnReportes = new Button();
            btnDashboard = new Button();
            btnCerrarSesion = new Button();

            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudTopN).BeginInit();

            // panelIzquierdo
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Width = 100;
            panelIzquierdo.BackColor = Color.FromArgb(25, 25, 111);

            // Reusar mismo helper de estilo
            void ConfigureLeftButton(Button b, int y, string text)
            {
                b.Size = new Size(panelIzquierdo.Width - 16, 56);
                b.Location = new Point(8, y);
                b.BackColor = Color.White;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                b.Text = text;
                b.TextAlign = ContentAlignment.MiddleRight;
                b.ImageAlign = ContentAlignment.MiddleLeft;
                b.TextImageRelation = TextImageRelation.ImageBeforeText;
            }

            ConfigureLeftButton(btnInicio, 20, "INICIO");
            ConfigureLeftButton(btnGestiones, 92, "GESTIONES");
            ConfigureLeftButton(btnControles, 164, "CONTROLES");
            ConfigureLeftButton(btnReportes, 236, "REPORTES");
            ConfigureLeftButton(btnDashboard, 308, "DASHBOARD");
            ConfigureLeftButton(btnCerrarSesion, 380, "CERRAR SESIÓN");

            panelIzquierdo.Controls.Add(btnInicio);
            panelIzquierdo.Controls.Add(btnGestiones);
            panelIzquierdo.Controls.Add(btnControles);
            panelIzquierdo.Controls.Add(btnReportes);
            panelIzquierdo.Controls.Add(btnDashboard);
            panelIzquierdo.Controls.Add(btnCerrarSesion);

            // dgvProducts
            dgvProducts.Location = new Point(panelIzquierdo.Width + 12, 50);
            dgvProducts.Size = new Size(700, 380);
            dgvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilos DataGridView (colores y fuentes)
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.GridColor = Color.FromArgb(221, 221, 221);
            dgvProducts.EnableHeadersVisualStyles = false;
            dgvProducts.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 111);
            dgvProducts.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvProducts.DefaultCellStyle.BackColor = Color.White;
            dgvProducts.DefaultCellStyle.ForeColor = Color.FromArgb(47, 79, 79);
            dgvProducts.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dgvProducts.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // btns y nuds (ubicación)
            btnRefresh.Location = new Point(panelIzquierdo.Width + 12, 12);
            btnRefresh.Size = new Size(90, 30);
            btnRefresh.Text = "Actualizar";
            btnRefresh.Click += BtnRefresh_Click;

            btnLowStock.Location = new Point(panelIzquierdo.Width + 110, 12);
            btnLowStock.Size = new Size(120, 30);
            btnLowStock.Text = "Bajo stock <= ";
            btnLowStock.Click += BtnLowStock_Click;

            nudThreshold.Location = new Point(panelIzquierdo.Width + 235, 16);
            nudThreshold.Minimum = 0;
            nudThreshold.Maximum = 10000;
            nudThreshold.Value = 10;
            nudThreshold.Size = new Size(60, 23);

            btnOutOfStock.Location = new Point(panelIzquierdo.Width + 305, 12);
            btnOutOfStock.Size = new Size(120, 30);
            btnOutOfStock.Text = "Agotados";
            btnOutOfStock.Click += BtnOutOfStock_Click;

            btnTopSelling.Location = new Point(panelIzquierdo.Width + 435, 12);
            btnTopSelling.Size = new Size(120, 30);
            btnTopSelling.Text = "Más vendidos Top";
            btnTopSelling.Click += BtnTopSelling_Click;

            nudTopN.Location = new Point(panelIzquierdo.Width + 560, 16);
            nudTopN.Minimum = 1;
            nudTopN.Maximum = 100;
            nudTopN.Value = 5;
            nudTopN.Size = new Size(60, 23);

            // InventoryForm (estética)
            Font = new Font("Segoe UI", 10F);
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(784, 450);
            Controls.Add(dgvProducts);
            Controls.Add(btnRefresh);
            Controls.Add(btnLowStock);
            Controls.Add(nudThreshold);
            Controls.Add(btnOutOfStock);
            Controls.Add(btnTopSelling);
            Controls.Add(nudTopN);
            Controls.Add(panelIzquierdo);
            Text = "Control de Inventario";
            StartPosition = FormStartPosition.CenterParent;

            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudTopN).EndInit();
        }
    }
}