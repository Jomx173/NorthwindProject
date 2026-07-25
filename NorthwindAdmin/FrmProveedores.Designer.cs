using System.Drawing;
using System.Windows.Forms;

namespace NorthwindAdmin
{
    partial class FrmProveedores
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelContenido;
        private Panel panel1;

        private Label lblMainTitle;
        private Label lblSubtitle;

        private Label lblId;
        private Label lblCompanyName;
        private Label lblContactName;
        private Label lblCountry;
        private Label lblPhone;
        private Label lblTituloProductos;

        private TextBox txtId;
        private TextBox txtCompanyName;
        private TextBox txtContactName;
        private TextBox txtCountry;
        private TextBox txtPhone;

        private DataGridView dgvProveedores;
        private DataGridView dgvProductos;

        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;

        private Label label15;
        private Label label13;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;

        private Button btnInicio;
        private Button btnGestiones;
        private Button btnControles;
        private Button btnReportes;
        private Button btnDashBoard;
        private Button btnCerrarSesion;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProveedores));
            panelContenido = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            lblMainTitle = new Label();
            lblSubtitle = new Label();
            lblId = new Label();
            lblCompanyName = new Label();
            lblContactName = new Label();
            txtId = new TextBox();
            txtCompanyName = new TextBox();
            txtContactName = new TextBox();
            lblCountry = new Label();
            lblPhone = new Label();
            txtCountry = new TextBox();
            txtPhone = new TextBox();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            btnRegistrar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            dgvProveedores = new DataGridView();
            lblTituloProductos = new Label();
            dgvProductos = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label7 = new Label();
            label13 = new Label();
            label15 = new Label();
            btnInicio = new Button();
            btnGestiones = new Button();
            btnControles = new Button();
            btnReportes = new Button();
            btnDashBoard = new Button();
            btnCerrarSesion = new Button();
            panelContenido.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.White;
            panelContenido.Controls.Add(panel2);
            panelContenido.Controls.Add(lblMainTitle);
            panelContenido.Controls.Add(lblSubtitle);
            panelContenido.Controls.Add(lblId);
            panelContenido.Controls.Add(lblCompanyName);
            panelContenido.Controls.Add(lblContactName);
            panelContenido.Controls.Add(txtId);
            panelContenido.Controls.Add(txtCompanyName);
            panelContenido.Controls.Add(txtContactName);
            panelContenido.Controls.Add(lblCountry);
            panelContenido.Controls.Add(lblPhone);
            panelContenido.Controls.Add(txtCountry);
            panelContenido.Controls.Add(txtPhone);
            panelContenido.Controls.Add(btnBuscar);
            panelContenido.Controls.Add(btnLimpiar);
            panelContenido.Controls.Add(btnRegistrar);
            panelContenido.Controls.Add(btnActualizar);
            panelContenido.Controls.Add(btnEliminar);
            panelContenido.Controls.Add(dgvProveedores);
            panelContenido.Controls.Add(lblTituloProductos);
            panelContenido.Controls.Add(dgvProductos);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(0, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1450, 850);
            panelContenido.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 858);
            panel2.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(45, 678);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(251, 29);
            label1.TabIndex = 11;
            label1.Text = "_________________";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(45, 277);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(251, 29);
            label2.TabIndex = 12;
            label2.Text = "_________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(45, 172);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(251, 29);
            label8.TabIndex = 11;
            label8.Text = "_________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.InactiveCaption;
            label9.Location = new Point(96, 136);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(120, 23);
            label9.TabIndex = 10;
            label9.Text = "NORTHWIND";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = SystemColors.InactiveCaption;
            label10.Location = new Point(84, 59);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(148, 28);
            label10.TabIndex = 9;
            label10.Text = " DE SISTEMAS";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label11.ForeColor = SystemColors.InactiveCaption;
            label11.Location = new Point(84, 91);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(155, 28);
            label11.TabIndex = 8;
            label11.Text = "DE SOFTWARE";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label12.ForeColor = SystemColors.InactiveCaption;
            label12.Location = new Point(58, 27);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(206, 28);
            label12.TabIndex = 7;
            label12.Text = "IMPLEMENTACIÓN ";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(14, 507);
            button1.Name = "button1";
            button1.Size = new Size(262, 60);
            button1.TabIndex = 5;
            button1.Text = "REPORTES";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(14, 735);
            button2.Name = "button2";
            button2.Size = new Size(259, 55);
            button2.TabIndex = 4;
            button2.Text = "CERRAR SESÍON";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(14, 604);
            button3.Name = "button3";
            button3.Size = new Size(262, 60);
            button3.TabIndex = 3;
            button3.Text = "DASHBOARD";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(14, 403);
            button4.Name = "button4";
            button4.Size = new Size(262, 60);
            button4.TabIndex = 2;
            button4.Text = "CONTROLES";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(11, 312);
            button5.Name = "button5";
            button5.Size = new Size(262, 62);
            button5.TabIndex = 1;
            button5.Text = "GESTIONES";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(11, 222);
            button6.Name = "button6";
            button6.Size = new Size(262, 52);
            button6.TabIndex = 0;
            button6.Text = "INICIO";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // lblMainTitle
            // 
            lblMainTitle.AutoSize = true;
            lblMainTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMainTitle.ForeColor = Color.FromArgb(17, 29, 122);
            lblMainTitle.Location = new Point(294, 3);
            lblMainTitle.Name = "lblMainTitle";
            lblMainTitle.Size = new Size(464, 46);
            lblMainTitle.TabIndex = 0;
            lblMainTitle.Text = "GESTIÓN DE PROVEEDORES";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.Gray;
            lblSubtitle.Location = new Point(316, 49);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(371, 23);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Administración de proveedores y sus productos";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(316, 72);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 2;
            lblId.Text = "ID";
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Location = new Point(457, 72);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(66, 20);
            lblCompanyName.TabIndex = 3;
            lblCompanyName.Text = "Empresa";
            // 
            // lblContactName
            // 
            lblContactName.AutoSize = true;
            lblContactName.Location = new Point(736, 72);
            lblContactName.Name = "lblContactName";
            lblContactName.Size = new Size(69, 20);
            lblContactName.TabIndex = 4;
            lblContactName.Text = "Contacto";
            // 
            // txtId
            // 
            txtId.Location = new Point(316, 94);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(90, 27);
            txtId.TabIndex = 5;
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(457, 91);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(250, 27);
            txtCompanyName.TabIndex = 6;
            // 
            // txtContactName
            // 
            txtContactName.Location = new Point(736, 91);
            txtContactName.Name = "txtContactName";
            txtContactName.Size = new Size(340, 27);
            txtContactName.TabIndex = 7;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(316, 139);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(34, 20);
            lblCountry.TabIndex = 8;
            lblCountry.Text = "País";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(594, 136);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(67, 20);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Teléfono";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(316, 163);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(250, 27);
            txtCountry.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(594, 165);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(340, 27);
            txtPhone.TabIndex = 11;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(1046, 206);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(120, 35);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(1190, 206);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(120, 35);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(316, 201);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(170, 40);
            btnRegistrar.TabIndex = 10;
            btnRegistrar.Text = "Guardar ";
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(507, 201);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(180, 40);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Modificar";
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(700, 201);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 40);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // dgvProveedores
            // 
            dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedores.ColumnHeadersHeight = 29;
            dgvProveedores.Location = new Point(316, 290);
            dgvProveedores.MultiSelect = false;
            dgvProveedores.Name = "dgvProveedores";
            dgvProveedores.ReadOnly = true;
            dgvProveedores.RowHeadersWidth = 51;
            dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProveedores.Size = new Size(520, 500);
            dgvProveedores.TabIndex = 13;
            dgvProveedores.CellClick += dgvProveedores_CellClick;
            // 
            // lblTituloProductos
            // 
            lblTituloProductos.AutoSize = true;
            lblTituloProductos.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTituloProductos.Location = new Point(876, 259);
            lblTituloProductos.Name = "lblTituloProductos";
            lblTituloProductos.Size = new Size(245, 28);
            lblTituloProductos.TabIndex = 14;
            lblTituloProductos.Text = "Productos del proveedor";
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeight = 29;
            dgvProductos.Location = new Point(876, 290);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(520, 500);
            dgvProductos.TabIndex = 15;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 29, 122);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(btnInicio);
            panel1.Controls.Add(btnGestiones);
            panel1.Controls.Add(btnControles);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnDashBoard);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 879);
            panel1.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.InactiveCaption;
            label6.Location = new Point(58, 27);
            label6.Name = "label6";
            label6.Size = new Size(201, 28);
            label6.TabIndex = 0;
            label6.Text = "IMPLEMENTACIÓN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.InactiveCaption;
            label4.Location = new Point(84, 59);
            label4.Name = "label4";
            label4.Size = new Size(143, 28);
            label4.TabIndex = 1;
            label4.Text = "DE SISTEMAS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.InactiveCaption;
            label5.Location = new Point(84, 91);
            label5.Name = "label5";
            label5.Size = new Size(155, 28);
            label5.TabIndex = 2;
            label5.Text = "DE SOFTWARE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.InactiveCaption;
            label3.Location = new Point(96, 136);
            label3.Name = "label3";
            label3.Size = new Size(120, 23);
            label3.TabIndex = 3;
            label3.Text = "NORTHWIND";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(45, 172);
            label7.Name = "label7";
            label7.Size = new Size(153, 20);
            label7.TabIndex = 4;
            label7.Text = "________________________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.White;
            label13.Location = new Point(45, 277);
            label13.Name = "label13";
            label13.Size = new Size(153, 20);
            label13.TabIndex = 5;
            label13.Text = "________________________";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = Color.White;
            label15.Location = new Point(45, 678);
            label15.Name = "label15";
            label15.Size = new Size(153, 20);
            label15.TabIndex = 6;
            label15.Text = "________________________";
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(11, 222);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(262, 52);
            btnInicio.TabIndex = 7;
            btnInicio.Text = "INICIO";
            // 
            // btnGestiones
            // 
            btnGestiones.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnGestiones.Image = (Image)resources.GetObject("btnGestiones.Image");
            btnGestiones.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestiones.Location = new Point(11, 312);
            btnGestiones.Name = "btnGestiones";
            btnGestiones.Size = new Size(262, 62);
            btnGestiones.TabIndex = 8;
            btnGestiones.Text = "GESTIONES";
            // 
            // btnControles
            // 
            btnControles.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnControles.Image = (Image)resources.GetObject("btnControles.Image");
            btnControles.ImageAlign = ContentAlignment.MiddleLeft;
            btnControles.Location = new Point(14, 403);
            btnControles.Name = "btnControles";
            btnControles.Size = new Size(262, 60);
            btnControles.TabIndex = 9;
            btnControles.Text = "CONTROLES";
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(14, 507);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(262, 60);
            btnReportes.TabIndex = 10;
            btnReportes.Text = "REPORTES";
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnDashBoard.Image = (Image)resources.GetObject("btnDashBoard.Image");
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(14, 604);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(262, 60);
            btnDashBoard.TabIndex = 11;
            btnDashBoard.Text = "DASHBOARD";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(14, 735);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(262, 55);
            btnCerrarSesion.TabIndex = 12;
            btnCerrarSesion.Text = "CERRAR SESIÓN";
            // 
            // FrmProveedores
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1450, 850);
            Controls.Add(panelContenido);
            Controls.Add(panel1);
            Name = "FrmProveedores";
            Text = "Gestión de Proveedores";
            Load += FrmProveedores_Load;
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProveedores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
