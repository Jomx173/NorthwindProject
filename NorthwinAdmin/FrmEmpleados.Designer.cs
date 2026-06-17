namespace NorthwinAdmin
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
            btnModificar = new Button();
            btnAgregar = new Button();
            dgvEmpleados = new DataGridView();
            dgvPedidos = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
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
            panel1.Location = new Point(284, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(915, 154);
            panel1.TabIndex = 3;
            // 
            // txtAddress
            // 
            txtAddress.BorderStyle = BorderStyle.None;
            txtAddress.Font = new Font("Nirmala UI", 10.8F);
            txtAddress.Location = new Point(553, 82);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(335, 34);
            txtAddress.TabIndex = 7;
            // 
            // txtHomePhone
            // 
            txtHomePhone.Font = new Font("Nirmala UI", 10.8F);
            txtHomePhone.Location = new Point(553, 29);
            txtHomePhone.Multiline = true;
            txtHomePhone.Name = "txtHomePhone";
            txtHomePhone.Size = new Size(335, 34);
            txtHomePhone.TabIndex = 6;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Nirmala UI", 10.8F);
            txtFirstName.Location = new Point(103, 79);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(335, 34);
            txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Nirmala UI", 10.8F);
            txtLastName.Location = new Point(103, 29);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(335, 34);
            txtLastName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Nirmala UI", 10.8F);
            label4.Location = new Point(462, 93);
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
            label2.Location = new Point(18, 82);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10.8F);
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnModificar);
            panel2.Controls.Add(btnAgregar);
            panel2.Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel2.Location = new Point(284, 219);
            panel2.Name = "panel2";
            panel2.Size = new Size(915, 61);
            panel2.TabIndex = 8;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.GradientActiveCaption;
            btnModificar.ForeColor = SystemColors.ButtonHighlight;
            btnModificar.Location = new Point(480, 7);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(409, 40);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.ActiveCaption;
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(21, 7);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(418, 40);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(283, 332);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(914, 232);
            dgvEmpleados.TabIndex = 9;
            // 
            // dgvPedidos
            // 
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(283, 617);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(914, 232);
            dgvPedidos.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold);
            label5.ForeColor = Color.SteelBlue;
            label5.Location = new Point(284, 298);
            label5.Name = "label5";
            label5.Size = new Size(218, 31);
            label5.TabIndex = 8;
            label5.Text = "Lista de Empleados";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 13.8F, FontStyle.Bold);
            label6.ForeColor = Color.SteelBlue;
            label6.Location = new Point(283, 583);
            label6.Name = "label6";
            label6.Size = new Size(236, 31);
            label6.TabIndex = 11;
            label6.Text = "Pedidos Gestionados";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(0, 0, 64);
            label7.Location = new Point(575, 9);
            label7.Name = "label7";
            label7.Size = new Size(354, 38);
            label7.TabIndex = 12;
            label7.Text = "GESTIÓN DE EMPLEADOS";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Location = new Point(-4, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(268, 887);
            panel3.TabIndex = 13;
            panel3.Paint += panel3_Paint;
            // 
            // FrmEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 885);
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
        private Panel panel3;
    }
}