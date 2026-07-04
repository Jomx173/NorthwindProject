namespace NortwindAdmin
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDashboard));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlClientes = new Panel();
            lblClientes = new Label();
            lblTituloClientes = new Label();
            pnlEmpleados = new Panel();
            lblEmpleados = new Label();
            lblTituloEmpleados = new Label();
            panel3 = new Panel();
            lblProductos = new Label();
            lblTituloProductos = new Label();
            panel4 = new Panel();
            lblOrdenes = new Label();
            lblTituloOrdenes = new Label();
            panel5 = new Panel();
            lblVentas = new Label();
            lblTituloventas = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            dgvOrdenes = new DataGridView();
            lblTituloOrdenesRecientes = new Label();
            sqlCommand3 = new Microsoft.Data.SqlClient.SqlCommand();
            chartVentasEmpleado = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTituloVentasEmpleado = new Label();
            label1 = new Label();
            lblFecha = new Label();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            button6 = new Button();
            btndasboard = new Button();
            btncontroles = new Button();
            btnreportes = new Button();
            button2 = new Button();
            btninicio = new Button();
            label2 = new Label();
            chartProductosVendidos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblTituloProductosVendidos = new Label();
            pnlClientes.SuspendLayout();
            pnlEmpleados.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartVentasEmpleado).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartProductosVendidos).BeginInit();
            SuspendLayout();
            // 
            // pnlClientes
            // 
            pnlClientes.BorderStyle = BorderStyle.FixedSingle;
            pnlClientes.Controls.Add(lblClientes);
            pnlClientes.Controls.Add(lblTituloClientes);
            pnlClientes.Location = new Point(800, 76);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(134, 98);
            pnlClientes.TabIndex = 0;
            // 
            // lblClientes
            // 
            lblClientes.AutoSize = true;
            lblClientes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClientes.Location = new Point(46, 61);
            lblClientes.Name = "lblClientes";
            lblClientes.Size = new Size(28, 21);
            lblClientes.TabIndex = 1;
            lblClientes.Text = "---";
            lblClientes.Click += lblClientes_Click;
            // 
            // lblTituloClientes
            // 
            lblTituloClientes.AutoSize = true;
            lblTituloClientes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloClientes.Location = new Point(34, 24);
            lblTituloClientes.Name = "lblTituloClientes";
            lblTituloClientes.Size = new Size(57, 17);
            lblTituloClientes.TabIndex = 0;
            lblTituloClientes.Text = "Clientes";
            lblTituloClientes.Click += label1_Click;
            // 
            // pnlEmpleados
            // 
            pnlEmpleados.BorderStyle = BorderStyle.FixedSingle;
            pnlEmpleados.Controls.Add(lblEmpleados);
            pnlEmpleados.Controls.Add(lblTituloEmpleados);
            pnlEmpleados.Location = new Point(430, 76);
            pnlEmpleados.Name = "pnlEmpleados";
            pnlEmpleados.Size = new Size(144, 98);
            pnlEmpleados.TabIndex = 1;
            pnlEmpleados.Paint += panel2_Paint;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmpleados.Location = new Point(63, 61);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(28, 21);
            lblEmpleados.TabIndex = 3;
            lblEmpleados.Text = "---";
            lblEmpleados.Click += lblEmpleados_Click;
            // 
            // lblTituloEmpleados
            // 
            lblTituloEmpleados.AutoSize = true;
            lblTituloEmpleados.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloEmpleados.Location = new Point(43, 24);
            lblTituloEmpleados.Name = "lblTituloEmpleados";
            lblTituloEmpleados.Size = new Size(75, 17);
            lblTituloEmpleados.TabIndex = 2;
            lblTituloEmpleados.Text = "Empleados";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblProductos);
            panel3.Controls.Add(lblTituloProductos);
            panel3.Location = new Point(613, 76);
            panel3.Name = "panel3";
            panel3.Size = new Size(136, 98);
            panel3.TabIndex = 2;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblProductos.Location = new Point(63, 61);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(28, 21);
            lblProductos.TabIndex = 3;
            lblProductos.Text = "---";
            // 
            // lblTituloProductos
            // 
            lblTituloProductos.AutoSize = true;
            lblTituloProductos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProductos.Location = new Point(40, 24);
            lblTituloProductos.Name = "lblTituloProductos";
            lblTituloProductos.Size = new Size(70, 17);
            lblTituloProductos.TabIndex = 2;
            lblTituloProductos.Text = "Productos";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblOrdenes);
            panel4.Controls.Add(lblTituloOrdenes);
            panel4.Location = new Point(250, 76);
            panel4.Name = "panel4";
            panel4.Size = new Size(134, 98);
            panel4.TabIndex = 3;
            // 
            // lblOrdenes
            // 
            lblOrdenes.AutoSize = true;
            lblOrdenes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOrdenes.Location = new Point(50, 61);
            lblOrdenes.Name = "lblOrdenes";
            lblOrdenes.Size = new Size(28, 21);
            lblOrdenes.TabIndex = 3;
            lblOrdenes.Text = "---";
            // 
            // lblTituloOrdenes
            // 
            lblTituloOrdenes.AutoSize = true;
            lblTituloOrdenes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloOrdenes.Location = new Point(40, 24);
            lblTituloOrdenes.Name = "lblTituloOrdenes";
            lblTituloOrdenes.Size = new Size(59, 17);
            lblTituloOrdenes.TabIndex = 2;
            lblTituloOrdenes.Text = "Ordenes";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblVentas);
            panel5.Controls.Add(lblTituloventas);
            panel5.Location = new Point(992, 76);
            panel5.Name = "panel5";
            panel5.Size = new Size(147, 98);
            panel5.TabIndex = 4;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVentas.Location = new Point(21, 61);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(28, 21);
            lblVentas.TabIndex = 3;
            lblVentas.Text = "---";
            // 
            // lblTituloventas
            // 
            lblTituloventas.AutoSize = true;
            lblTituloventas.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloventas.Location = new Point(32, 24);
            lblTituloventas.Name = "lblTituloventas";
            lblTituloventas.Size = new Size(97, 17);
            lblTituloventas.TabIndex = 2;
            lblTituloventas.Text = "Ventas Totales";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // dgvOrdenes
            // 
            dgvOrdenes.BorderStyle = BorderStyle.Fixed3D;
            dgvOrdenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrdenes.Location = new Point(250, 446);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.Size = new Size(889, 201);
            dgvOrdenes.TabIndex = 5;
            // 
            // lblTituloOrdenesRecientes
            // 
            lblTituloOrdenesRecientes.AutoSize = true;
            lblTituloOrdenesRecientes.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloOrdenesRecientes.Location = new Point(603, 404);
            lblTituloOrdenesRecientes.Name = "lblTituloOrdenesRecientes";
            lblTituloOrdenesRecientes.Size = new Size(157, 20);
            lblTituloOrdenesRecientes.TabIndex = 6;
            lblTituloOrdenesRecientes.Text = "Resumen de Ordenes";
            // 
            // sqlCommand3
            // 
            sqlCommand3.CommandTimeout = 30;
            sqlCommand3.EnableOptimizedParameterBinding = false;
            // 
            // chartVentasEmpleado
            // 
            chartVentasEmpleado.BackColor = SystemColors.ButtonHighlight;
            chartArea1.Name = "ChartArea1";
            chartVentasEmpleado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVentasEmpleado.Legends.Add(legend1);
            chartVentasEmpleado.Location = new Point(334, 234);
            chartVentasEmpleado.Name = "chartVentasEmpleado";
            chartVentasEmpleado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVentasEmpleado.Series.Add(series1);
            chartVentasEmpleado.Size = new Size(273, 167);
            chartVentasEmpleado.TabIndex = 7;
            // 
            // lblTituloVentasEmpleado
            // 
            lblTituloVentasEmpleado.AutoSize = true;
            lblTituloVentasEmpleado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloVentasEmpleado.Location = new Point(334, 199);
            lblTituloVentasEmpleado.Name = "lblTituloVentasEmpleado";
            lblTituloVentasEmpleado.Size = new Size(272, 20);
            lblTituloVentasEmpleado.TabIndex = 8;
            lblTituloVentasEmpleado.Text = "Participación de Ventas por Empleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(561, 21);
            label1.Name = "label1";
            label1.Size = new Size(216, 30);
            label1.TabIndex = 9;
            label1.Text = "Dashboard Gerencial";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFecha.Location = new Point(23, 9);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(29, 17);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "---s";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox7);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(btndasboard);
            panel1.Controls.Add(btncontroles);
            panel1.Controls.Add(btnreportes);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btninicio);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 571);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(15, 162);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 40);
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(18, 517);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(35, 35);
            pictureBox7.TabIndex = 18;
            pictureBox7.TabStop = false;
            pictureBox7.Click += pictureBox7_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(18, 428);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(45, 42);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 367);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(53, 38);
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(22, 311);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 38);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 38);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(27, 187);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 8;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.Location = new Point(15, 510);
            button6.Name = "button6";
            button6.Size = new Size(187, 49);
            button6.TabIndex = 6;
            button6.Text = "CERRAR SESIÓN";
            button6.UseVisualStyleBackColor = true;
            // 
            // btndasboard
            // 
            btndasboard.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btndasboard.Location = new Point(18, 428);
            btndasboard.Name = "btndasboard";
            btndasboard.Size = new Size(184, 43);
            btndasboard.TabIndex = 5;
            btndasboard.Text = "DASHBOARD";
            btndasboard.UseVisualStyleBackColor = true;
            // 
            // btncontroles
            // 
            btncontroles.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btncontroles.Location = new Point(18, 304);
            btncontroles.Name = "btncontroles";
            btncontroles.Size = new Size(184, 45);
            btncontroles.TabIndex = 4;
            btncontroles.Text = "CONTROLES";
            btncontroles.UseVisualStyleBackColor = true;
            // 
            // btnreportes
            // 
            btnreportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnreportes.Location = new Point(18, 367);
            btnreportes.Name = "btnreportes";
            btnreportes.Size = new Size(184, 42);
            btnreportes.TabIndex = 3;
            btnreportes.Text = "REPORTES";
            btnreportes.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Location = new Point(18, 235);
            button2.Name = "button2";
            button2.Size = new Size(184, 45);
            button2.TabIndex = 2;
            button2.Text = "GESTIONES";
            button2.UseVisualStyleBackColor = true;
            // 
            // btninicio
            // 
            btninicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btninicio.Location = new Point(15, 158);
            btninicio.Name = "btninicio";
            btninicio.Size = new Size(187, 44);
            btninicio.TabIndex = 1;
            btninicio.Text = "INICIO";
            btninicio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(37, 23);
            label2.Name = "label2";
            label2.Size = new Size(148, 100);
            label2.TabIndex = 0;
            label2.Text = "IMPLEMENTACIÓN\r\nDE SISTEMAS\r\nDE SOFTWARE\r\n\r\nNORTHWIND\r\n";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chartProductosVendidos
            // 
            chartArea2.Name = "ChartArea1";
            chartProductosVendidos.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartProductosVendidos.Legends.Add(legend2);
            chartProductosVendidos.Location = new Point(750, 234);
            chartProductosVendidos.Name = "chartProductosVendidos";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartProductosVendidos.Series.Add(series2);
            chartProductosVendidos.Size = new Size(273, 167);
            chartProductosVendidos.TabIndex = 11;
            chartProductosVendidos.Text = "chart1";
            // 
            // lblTituloProductosVendidos
            // 
            lblTituloProductosVendidos.AutoSize = true;
            lblTituloProductosVendidos.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProductosVendidos.Location = new Point(800, 199);
            lblTituloProductosVendidos.Name = "lblTituloProductosVendidos";
            lblTituloProductosVendidos.Size = new Size(180, 20);
            lblTituloProductosVendidos.TabIndex = 12;
            lblTituloProductosVendidos.Text = "Productos más vendidos";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1166, 656);
            Controls.Add(lblTituloProductosVendidos);
            Controls.Add(chartProductosVendidos);
            Controls.Add(panel4);
            Controls.Add(pnlClientes);
            Controls.Add(panel1);
            Controls.Add(lblFecha);
            Controls.Add(label1);
            Controls.Add(lblTituloVentasEmpleado);
            Controls.Add(chartVentasEmpleado);
            Controls.Add(lblTituloOrdenesRecientes);
            Controls.Add(dgvOrdenes);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(pnlEmpleados);
            Name = "FrmDashboard";
            Text = "Dashboard";
            Load += FrmDashboard_Load;
            pnlClientes.ResumeLayout(false);
            pnlClientes.PerformLayout();
            pnlEmpleados.ResumeLayout(false);
            pnlEmpleados.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartVentasEmpleado).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartProductosVendidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlClientes;
        private Panel pnlEmpleados;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblTituloClientes;
        private Label lblClientes;
        private Label lblEmpleados;
        private Label lblTituloEmpleados;
        private Label lblProductos;
        private Label lblTituloProductos;
        private Label lblOrdenes;
        private Label lblTituloOrdenes;
        private Label lblVentas;
        private Label lblTituloventas;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
        private DataGridView dgvOrdenes;
        private Label lblTituloOrdenesRecientes;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVentasEmpleado;
        private Label lblTituloVentasEmpleado;
        private Label label1;
        private Label lblFecha;
        private Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductosVendidos;
        private Label lblTituloProductosVendidos;
        private Label label2;
        private Button btninicio;
        private Button button6;
        private Button btndasboard;
        private Button btncontroles;
        private Button btnreportes;
        private Button button2;
        private Label label4;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
    }
}