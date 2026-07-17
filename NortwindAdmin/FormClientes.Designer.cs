namespace NortwindAdmin
{
    partial class FormClientes
    {
        private System.ComponentModel.IContainer components = null;

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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            groupBoxDatos = new GroupBox();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            txtIdCliente = new TextBox();
            txtEmpresa = new TextBox();
            txtContacto = new TextBox();
            txtCiudad = new TextBox();
            groupBoxBotones = new GroupBox();
            btnRegistrar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnBuscar = new Button();
            btnConsultar = new Button();
            dgvClientes = new DataGridView();
            panel1 = new Panel();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label13 = new Label();
            dgvPedidos = new DataGridView();
            label8 = new Label();
            label9 = new Label();
            groupBoxDatos.SuspendLayout();
            groupBoxBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // groupBoxDatos
            // 
            groupBoxDatos.BackColor = Color.FromArgb(240, 240, 240);
            groupBoxDatos.Controls.Add(label15);
            groupBoxDatos.Controls.Add(label17);
            groupBoxDatos.Controls.Add(label18);
            groupBoxDatos.Controls.Add(label19);
            groupBoxDatos.Controls.Add(txtIdCliente);
            groupBoxDatos.Controls.Add(txtEmpresa);
            groupBoxDatos.Controls.Add(txtContacto);
            groupBoxDatos.Controls.Add(txtCiudad);
            groupBoxDatos.ForeColor = Color.Gray;
            groupBoxDatos.Location = new Point(270, 46);
            groupBoxDatos.Name = "groupBoxDatos";
            groupBoxDatos.Size = new Size(732, 110);
            groupBoxDatos.TabIndex = 17;
            groupBoxDatos.TabStop = false;
            groupBoxDatos.Enter += groupBoxDatos_Enter;
            // 
            // label15
            // 
            label15.ForeColor = Color.Black;
            label15.Location = new Point(49, 32);
            label15.Name = "label15";
            label15.Size = new Size(100, 23);
            label15.TabIndex = 0;
            label15.Text = "ID del Cliente";
            label15.TextAlign = ContentAlignment.TopRight;
            // 
            // label17
            // 
            label17.ForeColor = Color.Black;
            label17.Location = new Point(367, 32);
            label17.Name = "label17";
            label17.Size = new Size(149, 23);
            label17.TabIndex = 1;
            label17.Text = "Nombre de la Empresa";
            // 
            // label18
            // 
            label18.ForeColor = Color.Black;
            label18.Location = new Point(6, 69);
            label18.Name = "label18";
            label18.Size = new Size(143, 23);
            label18.TabIndex = 2;
            label18.Text = "Nombre del Contacto";
            label18.TextAlign = ContentAlignment.TopRight;
            // 
            // label19
            // 
            label19.ForeColor = Color.Black;
            label19.Location = new Point(416, 69);
            label19.Name = "label19";
            label19.Size = new Size(100, 23);
            label19.TabIndex = 3;
            label19.Text = "Ciudad o País";
            label19.TextAlign = ContentAlignment.TopRight;
            // 
            // txtIdCliente
            // 
            txtIdCliente.Location = new Point(155, 32);
            txtIdCliente.Name = "txtIdCliente";
            txtIdCliente.Size = new Size(200, 25);
            txtIdCliente.TabIndex = 4;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(522, 32);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(200, 25);
            txtEmpresa.TabIndex = 5;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(155, 69);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(200, 25);
            txtContacto.TabIndex = 6;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(522, 66);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(200, 25);
            txtCiudad.TabIndex = 7;
            // 
            // groupBoxBotones
            // 
            groupBoxBotones.BackColor = Color.FromArgb(240, 240, 240);
            groupBoxBotones.Controls.Add(btnRegistrar);
            groupBoxBotones.Controls.Add(btnModificar);
            groupBoxBotones.Controls.Add(btnEliminar);
            groupBoxBotones.Controls.Add(btnBuscar);
            groupBoxBotones.Controls.Add(btnConsultar);
            groupBoxBotones.ForeColor = Color.Gray;
            groupBoxBotones.Location = new Point(270, 162);
            groupBoxBotones.Name = "groupBoxBotones";
            groupBoxBotones.Size = new Size(732, 73);
            groupBoxBotones.TabIndex = 18;
            groupBoxBotones.TabStop = false;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(157, 187, 215);
            btnRegistrar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(79, 19);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(100, 35);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(157, 187, 215);
            btnModificar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            btnModificar.ForeColor = Color.White;
            btnModificar.Location = new Point(201, 19);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 35);
            btnModificar.TabIndex = 1;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(157, 187, 215);
            btnEliminar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(322, 19);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 35);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(157, 187, 215);
            btnBuscar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(444, 19);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(100, 35);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.FromArgb(157, 187, 215);
            btnConsultar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold);
            btnConsultar.ForeColor = Color.White;
            btnConsultar.Location = new Point(568, 19);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(100, 35);
            btnConsultar.TabIndex = 4;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dgvClientes
            // 
            dataGridViewCellStyle13.BackColor = Color.FromArgb(245, 245, 245);
            dgvClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dgvClientes.BackgroundColor = Color.White;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(25, 25, 111);
            dataGridViewCellStyle14.Font = new Font("Nirmala UI", 10F);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("Nirmala UI", 10F);
            dataGridViewCellStyle15.ForeColor = Color.FromArgb(47, 79, 79);
            dataGridViewCellStyle15.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = DataGridViewTriState.False;
            dgvClientes.DefaultCellStyle = dataGridViewCellStyle15;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.FromArgb(221, 221, 221);
            dgvClientes.Location = new Point(270, 273);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.Size = new Size(732, 193);
            dgvClientes.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button10);
            panel1.Controls.Add(button11);
            panel1.Controls.Add(button12);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-3, -5);
            panel1.Name = "panel1";
            panel1.Size = new Size(229, 680);
            panel1.TabIndex = 1;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(10, 381);
            button7.Name = "button7";
            button7.Size = new Size(205, 39);
            button7.TabIndex = 0;
            button7.Text = "DASHBOARD";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(10, 452);
            button8.Name = "button8";
            button8.Size = new Size(205, 39);
            button8.TabIndex = 1;
            button8.Text = "CERRAR SESIÓN";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(10, 327);
            button9.Name = "button9";
            button9.Size = new Size(205, 39);
            button9.TabIndex = 2;
            button9.Text = "REPORTES";
            button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(10, 274);
            button10.Name = "button10";
            button10.Size = new Size(205, 39);
            button10.TabIndex = 3;
            button10.Text = "CONTROLES";
            button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(10, 220);
            button11.Name = "button11";
            button11.Size = new Size(205, 39);
            button11.TabIndex = 4;
            button11.Text = "GESTIONES";
            button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            button12.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(15, 141);
            button12.Name = "button12";
            button12.Size = new Size(200, 39);
            button12.TabIndex = 5;
            button12.Text = "INICIO";
            button12.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(10, 416);
            label1.Name = "label1";
            label1.Size = new Size(197, 23);
            label1.TabIndex = 6;
            label1.Text = "_________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(10, 180);
            label2.Name = "label2";
            label2.Size = new Size(197, 23);
            label2.TabIndex = 7;
            label2.Text = "_________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.InactiveCaption;
            label3.Location = new Point(60, 98);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 8;
            label3.Text = "NORTHWIND";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.InactiveCaption;
            label4.Location = new Point(45, 37);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 9;
            label4.Text = " DE SISTEMAS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.InactiveCaption;
            label5.Location = new Point(45, 58);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 10;
            label5.Text = "DE SOFTWARE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.InactiveCaption;
            label6.Location = new Point(23, 16);
            label6.Name = "label6";
            label6.Size = new Size(166, 21);
            label6.TabIndex = 11;
            label6.Text = "IMPLEMENTACIÓN ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(10, 107);
            label7.Name = "label7";
            label7.Size = new Size(197, 23);
            label7.TabIndex = 12;
            label7.Text = "_________________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label13.ForeColor = Color.FromArgb(0, 0, 64);
            label13.Location = new Point(526, 11);
            label13.Name = "label13";
            label13.Size = new Size(233, 32);
            label13.TabIndex = 0;
            label13.Text = "Gestión de Clientes";
            // 
            // dgvPedidos
            // 
            dataGridViewCellStyle16.BackColor = Color.FromArgb(245, 245, 245);
            dgvPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            dgvPedidos.BackgroundColor = Color.White;
            dataGridViewCellStyle17.BackColor = Color.FromArgb(25, 25, 111);
            dataGridViewCellStyle17.Font = new Font("Nirmala UI", 10F);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dgvPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = Color.White;
            dataGridViewCellStyle18.Font = new Font("Nirmala UI", 10F);
            dataGridViewCellStyle18.ForeColor = Color.FromArgb(47, 79, 79);
            dataGridViewCellStyle18.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = DataGridViewTriState.False;
            dgvPedidos.DefaultCellStyle = dataGridViewCellStyle18;
            dgvPedidos.EnableHeadersVisualStyles = false;
            dgvPedidos.GridColor = Color.FromArgb(221, 221, 221);
            dgvPedidos.Location = new Point(270, 504);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.Size = new Size(732, 159);
            dgvPedidos.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label8.ForeColor = SystemColors.MenuHighlight;
            label8.Location = new Point(270, 238);
            label8.Name = "label8";
            label8.Size = new Size(198, 32);
            label8.TabIndex = 21;
            label8.Text = "Lista de Clientes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label9.ForeColor = SystemColors.MenuHighlight;
            label9.Location = new Point(270, 469);
            label9.Name = "label9";
            label9.Size = new Size(232, 32);
            label9.TabIndex = 22;
            label9.Text = "Pedidos Realizados";
            label9.Click += label9_Click;
            // 
            // FormClientes
            // 
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(1044, 669);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dgvPedidos);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(groupBoxDatos);
            Controls.Add(groupBoxBotones);
            Controls.Add(dgvClientes);
            Font = new Font("Nirmala UI", 10F);
            Name = "FormClientes";
            Text = "Gestión de Clientes";
            Load += Form1_Load;
            groupBoxDatos.ResumeLayout(false);
            groupBoxDatos.PerformLayout();
            groupBoxBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxDatos;
        private GroupBox groupBoxBotones;
        private Label label15;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox txtIdCliente;
        private TextBox txtEmpresa;
        private TextBox txtContacto;
        private TextBox txtCiudad;
        private Button btnRegistrar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnBuscar;
        private Button btnConsultar;
        private DataGridView dgvClientes;
        private Panel panel1;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label13;
        private DataGridView dgvPedidos;
        private Label label8;
        private Label label9;
    }
}