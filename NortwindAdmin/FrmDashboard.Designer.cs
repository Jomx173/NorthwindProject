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
            pnlClientes.SuspendLayout();
            pnlEmpleados.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrdenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartVentasEmpleado).BeginInit();
            SuspendLayout();
            // 
            // pnlClientes
            // 
            pnlClientes.BorderStyle = BorderStyle.FixedSingle;
            pnlClientes.Controls.Add(lblClientes);
            pnlClientes.Controls.Add(lblTituloClientes);
            pnlClientes.Location = new Point(22, 66);
            pnlClientes.Name = "pnlClientes";
            pnlClientes.Size = new Size(135, 123);
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
            lblTituloClientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloClientes.Location = new Point(34, 24);
            lblTituloClientes.Name = "lblTituloClientes";
            lblTituloClientes.Size = new Size(51, 15);
            lblTituloClientes.TabIndex = 0;
            lblTituloClientes.Text = "Clientes";
            lblTituloClientes.Click += label1_Click;
            // 
            // pnlEmpleados
            // 
            pnlEmpleados.BorderStyle = BorderStyle.FixedSingle;
            pnlEmpleados.Controls.Add(lblEmpleados);
            pnlEmpleados.Controls.Add(lblTituloEmpleados);
            pnlEmpleados.Location = new Point(184, 66);
            pnlEmpleados.Name = "pnlEmpleados";
            pnlEmpleados.Size = new Size(144, 123);
            pnlEmpleados.TabIndex = 1;
            pnlEmpleados.Paint += panel2_Paint;
            // 
            // lblEmpleados
            // 
            lblEmpleados.AutoSize = true;
            lblEmpleados.Location = new Point(63, 61);
            lblEmpleados.Name = "lblEmpleados";
            lblEmpleados.Size = new Size(22, 15);
            lblEmpleados.TabIndex = 3;
            lblEmpleados.Text = "---";
            lblEmpleados.Click += lblEmpleados_Click;
            // 
            // lblTituloEmpleados
            // 
            lblTituloEmpleados.AutoSize = true;
            lblTituloEmpleados.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloEmpleados.Location = new Point(43, 24);
            lblTituloEmpleados.Name = "lblTituloEmpleados";
            lblTituloEmpleados.Size = new Size(66, 15);
            lblTituloEmpleados.TabIndex = 2;
            lblTituloEmpleados.Text = "Empleados";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblProductos);
            panel3.Controls.Add(lblTituloProductos);
            panel3.Location = new Point(354, 66);
            panel3.Name = "panel3";
            panel3.Size = new Size(147, 123);
            panel3.TabIndex = 2;
            // 
            // lblProductos
            // 
            lblProductos.AutoSize = true;
            lblProductos.Location = new Point(63, 61);
            lblProductos.Name = "lblProductos";
            lblProductos.Size = new Size(22, 15);
            lblProductos.TabIndex = 3;
            lblProductos.Text = "---";
            // 
            // lblTituloProductos
            // 
            lblTituloProductos.AutoSize = true;
            lblTituloProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloProductos.Location = new Point(40, 24);
            lblTituloProductos.Name = "lblTituloProductos";
            lblTituloProductos.Size = new Size(63, 15);
            lblTituloProductos.TabIndex = 2;
            lblTituloProductos.Text = "Productos";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblOrdenes);
            panel4.Controls.Add(lblTituloOrdenes);
            panel4.Location = new Point(529, 66);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 123);
            panel4.TabIndex = 3;
            // 
            // lblOrdenes
            // 
            lblOrdenes.AutoSize = true;
            lblOrdenes.Location = new Point(56, 61);
            lblOrdenes.Name = "lblOrdenes";
            lblOrdenes.Size = new Size(22, 15);
            lblOrdenes.TabIndex = 3;
            lblOrdenes.Text = "---";
            // 
            // lblTituloOrdenes
            // 
            lblTituloOrdenes.AutoSize = true;
            lblTituloOrdenes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloOrdenes.Location = new Point(40, 24);
            lblTituloOrdenes.Name = "lblTituloOrdenes";
            lblTituloOrdenes.Size = new Size(54, 15);
            lblTituloOrdenes.TabIndex = 2;
            lblTituloOrdenes.Text = "Ordenes";
            // 
            // panel5
            // 
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(lblVentas);
            panel5.Controls.Add(lblTituloventas);
            panel5.Location = new Point(702, 66);
            panel5.Name = "panel5";
            panel5.Size = new Size(147, 123);
            panel5.TabIndex = 4;
            // 
            // lblVentas
            // 
            lblVentas.AutoSize = true;
            lblVentas.Location = new Point(48, 61);
            lblVentas.Name = "lblVentas";
            lblVentas.Size = new Size(22, 15);
            lblVentas.TabIndex = 3;
            lblVentas.Text = "---";
            // 
            // lblTituloventas
            // 
            lblTituloventas.AutoSize = true;
            lblTituloventas.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloventas.Location = new Point(32, 24);
            lblTituloventas.Name = "lblTituloventas";
            lblTituloventas.Size = new Size(86, 15);
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
            dgvOrdenes.Location = new Point(22, 269);
            dgvOrdenes.Name = "dgvOrdenes";
            dgvOrdenes.Size = new Size(544, 236);
            dgvOrdenes.TabIndex = 5;
            // 
            // lblTituloOrdenesRecientes
            // 
            lblTituloOrdenesRecientes.AutoSize = true;
            lblTituloOrdenesRecientes.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloOrdenesRecientes.Location = new Point(247, 221);
            lblTituloOrdenesRecientes.Name = "lblTituloOrdenesRecientes";
            lblTituloOrdenesRecientes.Size = new Size(99, 15);
            lblTituloOrdenesRecientes.TabIndex = 6;
            lblTituloOrdenesRecientes.Text = "Ultimas Ordenes";
            // 
            // sqlCommand3
            // 
            sqlCommand3.CommandTimeout = 30;
            sqlCommand3.EnableOptimizedParameterBinding = false;
            // 
            // chartVentasEmpleado
            // 
            chartVentasEmpleado.BackColor = SystemColors.ActiveCaption;
            chartArea1.Name = "ChartArea1";
            chartVentasEmpleado.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartVentasEmpleado.Legends.Add(legend1);
            chartVentasEmpleado.Location = new Point(572, 269);
            chartVentasEmpleado.Name = "chartVentasEmpleado";
            chartVentasEmpleado.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVentasEmpleado.Series.Add(series1);
            chartVentasEmpleado.Size = new Size(339, 236);
            chartVentasEmpleado.TabIndex = 7;
            // 
            // lblTituloVentasEmpleado
            // 
            lblTituloVentasEmpleado.AutoSize = true;
            lblTituloVentasEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloVentasEmpleado.Location = new Point(658, 221);
            lblTituloVentasEmpleado.Name = "lblTituloVentasEmpleado";
            lblTituloVentasEmpleado.Size = new Size(123, 15);
            lblTituloVentasEmpleado.TabIndex = 8;
            lblTituloVentasEmpleado.Text = "Ventas por Empleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(342, 23);
            label1.Name = "label1";
            label1.Size = new Size(216, 30);
            label1.TabIndex = 9;
            label1.Text = "Dashboard Gerencial";
            // 
            // FrmDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(924, 498);
            Controls.Add(label1);
            Controls.Add(lblTituloVentasEmpleado);
            Controls.Add(chartVentasEmpleado);
            Controls.Add(lblTituloOrdenesRecientes);
            Controls.Add(dgvOrdenes);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pnlEmpleados);
            Controls.Add(pnlClientes);
            Name = "FrmDashboard";
            Text = "FrmDashboard";
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
    }
}