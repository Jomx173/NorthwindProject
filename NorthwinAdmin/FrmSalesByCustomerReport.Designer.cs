using Domain.Models.DTO;
using Domain.Services;

namespace NorthwindAdmin
{
    partial class FrmSalesByCustomerReport
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView dataGridViewVentas;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewVentas = new DataGridView();
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
            label1 = new Label();
            btnExportar = new Button();
            label2 = new Label();
            panel2 = new Panel();
            lblTotalVentas = new Label();
            label5 = new Label();
            panel3 = new Panel();
            lblPedidosRealizados = new Label();
            label6 = new Label();
            panel5 = new Panel();
            dtpHasta = new DateTimePicker();
            label4 = new Label();
            dtpDesde = new DateTimePicker();
            label3 = new Label();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            panel4 = new Panel();
            lblMejorCliente = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewVentas
            // 
            dataGridViewVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewVentas.Location = new Point(287, 357);
            dataGridViewVentas.Name = "dataGridViewVentas";
            dataGridViewVentas.RowHeadersWidth = 51;
            dataGridViewVentas.Size = new Size(1006, 315);
            dataGridViewVentas.TabIndex = 0;
            dataGridViewVentas.CellContentClick += dataGridViewVentas_CellContentClick;
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
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 684);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
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
            button2.Click += button2_Click_1;
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
            label16.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(11, 554);
            label16.Name = "label16";
            label16.Size = new Size(234, 29);
            label16.TabIndex = 8;
            label16.Text = "_________________";
            label16.Click += label16_Click;
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
            label9.Click += label9_Click;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(439, 41);
            label1.TabIndex = 2;
            label1.Text = "Reporte de Ventas por Cliente";
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(1184, 12);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(109, 38);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(304, 61);
            label2.Name = "label2";
            label2.Size = new Size(390, 20);
            label2.TabIndex = 4;
            label2.Text = "Evaluación del comportamiento comercial de la clientela.";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblTotalVentas);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(287, 200);
            panel2.Name = "panel2";
            panel2.Size = new Size(261, 125);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // lblTotalVentas
            // 
            lblTotalVentas.AutoSize = true;
            lblTotalVentas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalVentas.Location = new Point(11, 48);
            lblTotalVentas.Name = "lblTotalVentas";
            lblTotalVentas.Size = new Size(26, 41);
            lblTotalVentas.TabIndex = 1;
            lblTotalVentas.Text = ".";
            lblTotalVentas.Click += label8_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 10);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 0;
            label5.Text = "Total de Ventas";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPedidosRealizados);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(656, 200);
            panel3.Name = "panel3";
            panel3.Size = new Size(271, 125);
            panel3.TabIndex = 6;
            panel3.Paint += panel3_Paint;
            // 
            // lblPedidosRealizados
            // 
            lblPedidosRealizados.AutoSize = true;
            lblPedidosRealizados.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPedidosRealizados.Location = new Point(15, 48);
            lblPedidosRealizados.Name = "lblPedidosRealizados";
            lblPedidosRealizados.Size = new Size(26, 41);
            lblPedidosRealizados.TabIndex = 3;
            lblPedidosRealizados.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 10);
            label6.Name = "label6";
            label6.Size = new Size(137, 20);
            label6.TabIndex = 0;
            label6.Text = "Pedidos Realizados";
            label6.Click += label6_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(dtpHasta);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(dtpDesde);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(btnBuscar);
            panel5.Controls.Add(btnLimpiar);
            panel5.Location = new Point(287, 107);
            panel5.Name = "panel5";
            panel5.Size = new Size(1006, 66);
            panel5.TabIndex = 6;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(467, 18);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(283, 27);
            dtpHasta.TabIndex = 5;
            dtpHasta.ValueChanged += dtpHasta_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(407, 22);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "Hasta:";
            label4.Click += label4_Click;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(77, 18);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(283, 27);
            dtpDesde.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 22);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Desde:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(801, 16);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 1;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button3_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(901, 16);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 0;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblMejorCliente);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(1031, 200);
            panel4.Name = "panel4";
            panel4.Size = new Size(262, 125);
            panel4.TabIndex = 7;
            // 
            // lblMejorCliente
            // 
            lblMejorCliente.AutoSize = true;
            lblMejorCliente.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMejorCliente.Location = new Point(8, 48);
            lblMejorCliente.Name = "lblMejorCliente";
            lblMejorCliente.Size = new Size(26, 41);
            lblMejorCliente.TabIndex = 2;
            lblMejorCliente.Text = ".";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 10);
            label7.Name = "label7";
            label7.Size = new Size(98, 20);
            label7.TabIndex = 0;
            label7.Text = "Mejor Cliente";
            // 
            // FrmSalesByCustomerReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 684);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(btnExportar);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(dataGridViewVentas);
            Name = "FrmSalesByCustomerReport";
            Text = "Reporte de Ventas por Cliente";
            Load += FrmSalesByCustomerReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewVentas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
        private Panel panel1;
        private Label label1;
        private Button btnExportar;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private DateTimePicker dtpDesde;
        private Label label3;
        private Button btnBuscar;
        private Button btnLimpiar;
        private DateTimePicker dtpHasta;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblTotalVentas;
        private Label lblMejorCliente;
        private Label lblPedidosRealizados;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label12;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label16;
        private Label label14;
        private Button button6;
    }
}