namespace NorthwindAdmin
{
    partial class FrmVentasEmpleados
    {
        /// <summary>
        /// Required designer variable.
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            dtpHasta = new DateTimePicker();
            label4 = new Label();
            dtpDesde = new DateTimePicker();
            label3 = new Label();
            MejorVendedor = new Panel();
            lblResultadoMejorV = new Label();
            lblMejorVendedor = new Label();
            TotalVentas = new Panel();
            lblResultadoVentas = new Label();
            lblTotalVentas = new Label();
            PedidosAtendidos = new Panel();
            lblResultadoPedidos = new Label();
            lblPedidosAtendidos = new Label();
            btnExportar = new Button();
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
            label8 = new Label();
            label9 = new Label();
            dgvVentasEmpleados = new DataGridView();
            panel2.SuspendLayout();
            MejorVendedor.SuspendLayout();
            TotalVentas.SuspendLayout();
            PedidosAtendidos.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasEmpleados).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(480, 41);
            label1.TabIndex = 1;
            label1.Text = "Reporte de Ventas por Empleado\r\n";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(305, 60);
            label2.Name = "label2";
            label2.Size = new Size(389, 23);
            label2.TabIndex = 2;
            label2.Text = "Evaluación del desempeño comercial del personal";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnBuscar);
            panel2.Controls.Add(dtpHasta);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtpDesde);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(305, 104);
            panel2.Name = "panel2";
            panel2.Size = new Size(1061, 58);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.Location = new Point(901, 13);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(147, 39);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click_1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.Transparent;
            btnBuscar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(734, 13);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(147, 39);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(442, 20);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(286, 27);
            dtpHasta.TabIndex = 3;
            dtpHasta.Value = new DateTime(2026, 6, 17, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(378, 21);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 2;
            label4.Text = "Hasta:";
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(81, 21);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(291, 27);
            dtpDesde.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 24);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 0;
            label3.Text = "Desde:";
            // 
            // MejorVendedor
            // 
            MejorVendedor.Controls.Add(lblResultadoMejorV);
            MejorVendedor.Controls.Add(lblMejorVendedor);
            MejorVendedor.Location = new Point(1070, 184);
            MejorVendedor.Name = "MejorVendedor";
            MejorVendedor.Size = new Size(296, 109);
            MejorVendedor.TabIndex = 5;
            // 
            // lblResultadoMejorV
            // 
            lblResultadoMejorV.AutoSize = true;
            lblResultadoMejorV.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoMejorV.Location = new Point(43, 48);
            lblResultadoMejorV.Name = "lblResultadoMejorV";
            lblResultadoMejorV.Size = new Size(28, 38);
            lblResultadoMejorV.TabIndex = 3;
            lblResultadoMejorV.Text = "-";
            lblResultadoMejorV.Click += lblResultadoMejorV_Click;
            // 
            // lblMejorVendedor
            // 
            lblMejorVendedor.AutoSize = true;
            lblMejorVendedor.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMejorVendedor.Location = new Point(43, 15);
            lblMejorVendedor.Name = "lblMejorVendedor";
            lblMejorVendedor.Size = new Size(121, 20);
            lblMejorVendedor.TabIndex = 3;
            lblMejorVendedor.Text = "Mejor Vendedor";
            lblMejorVendedor.TextAlign = ContentAlignment.BottomCenter;
            // 
            // TotalVentas
            // 
            TotalVentas.Controls.Add(lblResultadoVentas);
            TotalVentas.Controls.Add(lblTotalVentas);
            TotalVentas.Location = new Point(305, 181);
            TotalVentas.Name = "TotalVentas";
            TotalVentas.Size = new Size(314, 109);
            TotalVentas.TabIndex = 6;
            // 
            // lblResultadoVentas
            // 
            lblResultadoVentas.AutoSize = true;
            lblResultadoVentas.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoVentas.Location = new Point(60, 48);
            lblResultadoVentas.Name = "lblResultadoVentas";
            lblResultadoVentas.Size = new Size(101, 38);
            lblResultadoVentas.TabIndex = 1;
            lblResultadoVentas.Text = "L. 0.00";
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVentas.Location = new Point(60, 15);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(112, 20);
            lblTotalVentas.TabIndex = 0;
            lblTotalVentas.Text = "Total de Ventas";
            // 
            // PedidosAtendidos
            // 
            PedidosAtendidos.Controls.Add(lblResultadoPedidos);
            PedidosAtendidos.Controls.Add(lblPedidosAtendidos);
            PedidosAtendidos.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PedidosAtendidos.Location = new Point(704, 184);
            PedidosAtendidos.Name = "PedidosAtendidos";
            PedidosAtendidos.Size = new Size(296, 109);
            PedidosAtendidos.TabIndex = 6;
            // 
            // lblResultadoPedidos
            // 
            lblResultadoPedidos.AutoSize = true;
            lblResultadoPedidos.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultadoPedidos.Location = new Point(67, 48);
            lblResultadoPedidos.Name = "lblResultadoPedidos";
            lblResultadoPedidos.Size = new Size(28, 38);
            lblResultadoPedidos.TabIndex = 2;
            lblResultadoPedidos.Text = "-";
            // 
            // lblPedidosAtendidos
            // 
            lblPedidosAtendidos.AutoSize = true;
            lblPedidosAtendidos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidosAtendidos.Location = new Point(53, 15);
            lblPedidosAtendidos.Name = "lblPedidosAtendidos";
            lblPedidosAtendidos.Size = new Size(131, 20);
            lblPedidosAtendidos.TabIndex = 2;
            lblPedidosAtendidos.Text = "Pedidos Atentidos";
            // 
            // btnExportar
            // 
            btnExportar.BackColor = Color.Transparent;
            btnExportar.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.Location = new Point(1219, 20);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(147, 39);
            btnExportar.TabIndex = 6;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = false;
            btnExportar.Click += btnExportar_Click;
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
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(262, 694);
            panel1.TabIndex = 8;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(11, 508);
            button6.Name = "button6";
            button6.Size = new Size(234, 52);
            button6.TabIndex = 14;
            button6.Text = "DASHBOARD";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(11, 602);
            button5.Name = "button5";
            button5.Size = new Size(234, 52);
            button5.TabIndex = 13;
            button5.Text = "CERRAR SESIÓN";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(11, 436);
            button4.Name = "button4";
            button4.Size = new Size(234, 52);
            button4.TabIndex = 12;
            button4.Text = "REPORTES";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(11, 365);
            button3.Name = "button3";
            button3.Size = new Size(234, 52);
            button3.TabIndex = 11;
            button3.Text = "CONTROLES";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(11, 294);
            button2.Name = "button2";
            button2.Size = new Size(234, 52);
            button2.TabIndex = 10;
            button2.Text = "GESTIONES";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(11, 185);
            button1.Name = "button1";
            button1.Size = new Size(234, 52);
            button1.TabIndex = 9;
            button1.Text = "INICIO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(11, 554);
            label16.Name = "label16";
            label16.Size = new Size(234, 29);
            label16.TabIndex = 8;
            label16.Text = "_________________";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(11, 240);
            label14.Name = "label14";
            label14.Size = new Size(234, 29);
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
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(11, 143);
            label8.Name = "label8";
            label8.Size = new Size(234, 29);
            label8.TabIndex = 0;
            label8.Text = "_________________";
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
            // dgvVentasEmpleados
            // 
            dgvVentasEmpleados.AllowUserToAddRows = false;
            dgvVentasEmpleados.AllowUserToDeleteRows = false;
            dgvVentasEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasEmpleados.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvVentasEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvVentasEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVentasEmpleados.EnableHeadersVisualStyles = false;
            dgvVentasEmpleados.Location = new Point(305, 311);
            dgvVentasEmpleados.MultiSelect = false;
            dgvVentasEmpleados.Name = "dgvVentasEmpleados";
            dgvVentasEmpleados.ReadOnly = true;
            dgvVentasEmpleados.RowHeadersVisible = false;
            dgvVentasEmpleados.RowHeadersWidth = 51;
            dgvVentasEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentasEmpleados.Size = new Size(1061, 361);
            dgvVentasEmpleados.TabIndex = 7;
            // 
            // FrmVentasEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 684);
            Controls.Add(panel1);
            Controls.Add(btnExportar);
            Controls.Add(dgvVentasEmpleados);
            Controls.Add(PedidosAtendidos);
            Controls.Add(TotalVentas);
            Controls.Add(MejorVendedor);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmVentasEmpleados";
            Text = "FrmVentasEmpleados";
            Load += FrmVentasEmpleados_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            MejorVendedor.ResumeLayout(false);
            MejorVendedor.PerformLayout();
            TotalVentas.ResumeLayout(false);
            TotalVentas.PerformLayout();
            PedidosAtendidos.ResumeLayout(false);
            PedidosAtendidos.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVentasEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Button btnLimpiar;
        private Button btnBuscar;
        private DateTimePicker dtpHasta;
        private Label label4;
        private DateTimePicker dtpDesde;
        private Panel MejorVendedor;
        private Panel TotalVentas;
        private Panel PedidosAtendidos;
        private Label lblResultadoVentas;
        private Label lblTotalVentas;
        private Label lblResultadoMejorV;
        private Label lblMejorVendedor;
        private Label lblResultadoPedidos;
        private Label lblPedidosAtendidos;
        private Button btnExportar;
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
        private Label label8;
        private Label label9;
        private DataGridView dgvVentasEmpleados;
    }
}