namespace NorthwindAdmin
{
    partial class FrmInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label16 = new Label();
            label14 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dgvProducts = new DataGridView();
            btnRefresh = new Button();
            btnLowStock = new Button();
            btnOutOfStock = new Button();
            btnTopSelling = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 684);
            panel1.TabIndex = 2;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button6.Image = Properties.Resources.dashboard1;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(11, 508);
            button6.Name = "button6";
            button6.Size = new Size(234, 52);
            button6.TabIndex = 14;
            button6.Text = "DASHBOARD";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button5.Image = Properties.Resources.salir1;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(11, 602);
            button5.Name = "button5";
            button5.Size = new Size(234, 52);
            button5.TabIndex = 13;
            button5.Text = "CERRAR SESIÓN";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button4.Image = Properties.Resources.reportes1;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(11, 436);
            button4.Name = "button4";
            button4.Size = new Size(234, 52);
            button4.TabIndex = 12;
            button4.Text = "REPORTES";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.Image = Properties.Resources.controles1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(11, 365);
            button3.Name = "button3";
            button3.Size = new Size(234, 52);
            button3.TabIndex = 11;
            button3.Text = "CONTROLES";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.Image = Properties.Resources.gestiones1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(11, 294);
            button2.Name = "button2";
            button2.Size = new Size(234, 52);
            button2.TabIndex = 10;
            button2.Text = "GESTIONES";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.inicio2;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(11, 185);
            button1.Name = "button1";
            button1.Size = new Size(234, 52);
            button1.TabIndex = 9;
            button1.Text = "INICIO";
            button1.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(11, 554);
            label16.Name = "label16";
            label16.Size = new Size(251, 29);
            label16.TabIndex = 8;
            label16.Text = "_________________";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(11, 240);
            label14.Name = "label14";
            label14.Size = new Size(251, 29);
            label14.TabIndex = 6;
            label14.Text = "_________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.InactiveCaption;
            label12.Location = new Point(68, 130);
            label12.Name = "label12";
            label12.Size = new Size(120, 23);
            label12.TabIndex = 4;
            label12.Text = "NORTHWIND";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = SystemColors.InactiveCaption;
            label11.Location = new Point(51, 49);
            label11.Name = "label11";
            label11.Size = new Size(148, 28);
            label11.TabIndex = 3;
            label11.Text = " DE SISTEMAS";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = SystemColors.InactiveCaption;
            label10.Location = new Point(51, 77);
            label10.Name = "label10";
            label10.Size = new Size(155, 28);
            label10.TabIndex = 2;
            label10.Text = "DE SOFTWARE";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label9.ForeColor = SystemColors.InactiveCaption;
            label9.Location = new Point(26, 21);
            label9.Name = "label9";
            label9.Size = new Size(206, 28);
            label9.TabIndex = 1;
            label9.Text = "IMPLEMENTACIÓN ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(11, 143);
            label8.Name = "label8";
            label8.Size = new Size(251, 29);
            label8.TabIndex = 0;
            label8.Text = "_________________";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(317, 143);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(863, 541);
            dgvProducts.TabIndex = 3;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // btnRefresh
            // 
            btnRefresh.DialogResult = DialogResult.Cancel;
            btnRefresh.Location = new Point(317, 96);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Actulizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnLowStock
            // 
            btnLowStock.Location = new Point(550, 96);
            btnLowStock.Name = "btnLowStock";
            btnLowStock.Size = new Size(94, 29);
            btnLowStock.TabIndex = 5;
            btnLowStock.Text = "Bajo Stock";
            btnLowStock.UseVisualStyleBackColor = true;
            btnLowStock.Click += btnLowStock_Click;
            // 
            // btnOutOfStock
            // 
            btnOutOfStock.Location = new Point(687, 96);
            btnOutOfStock.Name = "btnOutOfStock";
            btnOutOfStock.Size = new Size(94, 29);
            btnOutOfStock.TabIndex = 6;
            btnOutOfStock.Text = "Agotados";
            btnOutOfStock.UseVisualStyleBackColor = true;
            btnOutOfStock.Click += btnOutOfStock_Click;
            // 
            // btnTopSelling
            // 
            btnTopSelling.Location = new Point(907, 96);
            btnTopSelling.Name = "btnTopSelling";
            btnTopSelling.Size = new Size(124, 29);
            btnTopSelling.TabIndex = 7;
            btnTopSelling.Text = "Top Vendidos";
            btnTopSelling.UseVisualStyleBackColor = true;
            btnTopSelling.Click += btnTopSelling_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(434, 98);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 27);
            numericUpDown1.TabIndex = 8;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(1053, 98);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(61, 27);
            numericUpDown2.TabIndex = 9;
            // 
            // FrmInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 683);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(btnTopSelling);
            Controls.Add(btnOutOfStock);
            Controls.Add(btnLowStock);
            Controls.Add(btnRefresh);
            Controls.Add(dgvProducts);
            Controls.Add(panel1);
            Name = "FrmInventario";
            Text = "FrmInventario";


            ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();


            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label16;
        private Label label14;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private DataGridView dgvProducts;
        private Button btnRefresh;
        private Button btnLowStock;
        private Button btnOutOfStock;
        private Button btnTopSelling;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}