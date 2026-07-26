namespace NorthwindAdmin
{
    partial class FrmEmpleados
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
            txtAddress = new TextBox();
            txtHomePhone = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnLimpiar = new Button();
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvEmpleados = new DataGridView();
            dgvPedidos = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
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
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtHomePhone);
            panel1.Controls.Add(txtFirstName);
            panel1.Controls.Add(txtLastName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(283, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 154);
            panel1.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Nirmala UI", 10.8F);
            txtAddress.Location = new Point(553, 83);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(335, 35);
            txtAddress.TabIndex = 3;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Font = new Font("Nirmala UI", 10.8F);
            txtHomePhone.Location = new Point(553, 29);
            txtHomePhone.Multiline = true;
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(335, 33);
            txtHomePhone.TabIndex = 2;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Nirmala UI", 10.8F);
            txtFirstName.Location = new Point(104, 29);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(335, 33);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Nirmala UI", 10.8F);
            txtLastName.Location = new Point(104, 83);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(335, 33);
            txtLastName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.8F);
            label4.Location = new Point(462, 83);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 3;
            label4.Text = "Dirección:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 10.8F);
            label3.Location = new Point(462, 32);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 2;
            label3.Text = "Teléfono:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10.8F);
            label2.Location = new Point(18, 83);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.8F);
            label1.Location = new Point(21, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnLimpiar);
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnAgregar);
            panel2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(283, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(915, 61);
            panel2.TabIndex = 8;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ActiveCaption;
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(616, 7);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(272, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.SkyBlue;
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(322, 7);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(272, 40);
            btnModificar.TabIndex = 5;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.SteelBlue;
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(18, 7);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(274, 40);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(283, 317);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(914, 224);
            dgvEmpleados.TabIndex = 9;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(283, 579);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(914, 224);
            dgvPedidos.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(283, 285);
            label5.Name = "label5";
            label5.Size = new Size(193, 28);
            label5.TabIndex = 8;
            label5.Text = "Lista de Empleados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(283, 549);
            label6.Name = "label6";
            label6.Size = new Size(207, 28);
            label6.TabIndex = 11;
            label6.Text = "Pedidos Gestionados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(575, 9);
            label7.Name = "label7";
            label7.Size = new Size(314, 35);
            label7.TabIndex = 12;
            label7.Text = "GESTIÓN DE EMPLEADOS";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(button6);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(262, 824);
            panel3.TabIndex = 13;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(11, 549);
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
            button5.Location = new Point(11, 657);
            button5.Name = "button5";
            button5.Size = new Size(234, 52);
            button5.TabIndex = 13;
            button5.Text = "CERRAR SESIÓN";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(11, 476);
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
            button3.Location = new Point(11, 403);
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
            button2.Location = new Point(11, 333);
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
            button1.Location = new Point(11, 215);
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
            label16.Location = new Point(11, 605);
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
            label14.Location = new Point(11, 271);
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
            label12.Location = new Point(69, 131);
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
            label8.Location = new Point(11, 163);
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
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 749);
            Controls.Add(panel3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvPedidos);
            Controls.Add(dgvEmpleados);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmEmpleados";
            Text = "FrmEmpleados";
            Load += FrmEmpleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAddress;
        private TextBox txtHomePhone;
        private Panel panel2;
        private Button btnModificar;
        private Button btnAgregar;
        private DataGridView dgvEmpleados;
        private DataGridView dgvPedidos;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnLimpiar;
        private Panel panel3;
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
    }
}