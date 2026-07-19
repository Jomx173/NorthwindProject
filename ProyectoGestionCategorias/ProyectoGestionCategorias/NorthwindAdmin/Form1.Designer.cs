using System.Windows.Forms;
using System.Drawing;

namespace NorthwindAdmin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnCategorias;
        private Label lblBienvenida;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnCategorias = new Button();
            this.lblBienvenida = new Label();
            this.SuspendLayout();

            // lblBienvenida
            this.lblBienvenida.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblBienvenida.Location = new Point(50, 60);
            this.lblBienvenida.Size = new Size(500, 40);
            this.lblBienvenida.Text = "Módulo de Administración General";
            this.lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;

            // btnCategorias
            this.btnCategorias.BackColor = Color.FromArgb(17, 29, 122);
            this.btnCategorias.FlatStyle = FlatStyle.Flat;
            this.btnCategorias.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.btnCategorias.ForeColor = Color.White;
            this.btnCategorias.Location = new Point(150, 140);
            this.btnCategorias.Size = new Size(300, 50);
            this.btnCategorias.Text = "Gestionar Categorías";
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.lblBienvenida);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio - Sistema Northwind";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}