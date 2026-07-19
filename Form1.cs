csharp NortwindAdmin\Form1.Designer.cs
using System.Drawing;
using System.Windows.Forms;

namespace NortwindAdmin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridView1;
        private Button btnOpenInventory;
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
            dataGridView1 = new DataGridView();
            btnOpenInventory = new Button();
            panelIzquierdo = new Panel();
            btnInicio = new Button();
            btnGestiones = new Button();
            btnControles = new Button();
            btnReportes = new Button();
            btnDashboard = new Button();
            btnCerrarSesion = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // panelIzquierdo
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Width = 100;
            panelIzquierdo.BackColor = Color.FromArgb(25, 25, 111);

            // Botones en panel izquierdo (estética)
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

            // Añadir botones al panel
            panelIzquierdo.Controls.Add(btnInicio);
            panelIzquierdo.Controls.Add(btnGestiones);
            panelIzquierdo.Controls.Add(btnControles);
            panelIzquierdo.Controls.Add(btnReportes);
            panelIzquierdo.Controls.Add(btnDashboard);
            panelIzquierdo.Controls.Add(btnCerrarSesion);

            // dataGridView1
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(panelIzquierdo.Width + 10, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(680, 370);
            dataGridView1.TabIndex = 0;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilos DataGridView (colores y fuentes)
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.GridColor = Color.FromArgb(221, 221, 221);
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 25, 111);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(47, 79, 79);
            dataGridView1.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // btnOpenInventory
            btnOpenInventory.Location = new Point(panelIzquierdo.Width + 10, 12);
            btnOpenInventory.Name = "btnOpenInventory";
            btnOpenInventory.Size = new Size(160, 36);
            btnOpenInventory.Text = "Control Inventario";
            btnOpenInventory.UseVisualStyleBackColor = true;
            btnOpenInventory.Click += btnOpenInventory_Click;

            // Form1 (estética)
            Font = new Font("Segoe UI", 10F);
            BackColor = Color.FromArgb(240, 240, 240);
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenInventory);
            Controls.Add(dataGridView1);
            Controls.Add(panelIzquierdo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }
    }
}