namespace NorthwindAdmin
{
    partial class FrmProductos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label14 = new Label();
            label16 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtIdProducto = new TextBox();
            btnBuscar = new Button();
            btnMostrarTodos = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            btnEliminar = new Button();
            cmbCategorias = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            label15 = new Label();
            label13 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnReportes = new Button();
            btnCerrarSesion = new Button();
            btnDashBoard = new Button();
            btnControles = new Button();
            btnGestiones = new Button();
            btnInicio = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label8
            // 
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 23);
            label8.TabIndex = 0;
            // 
            // label9
            // 
            label9.Location = new Point(0, 0);
            label9.Name = "label9";
            label9.Size = new Size(100, 23);
            label9.TabIndex = 0;
            // 
            // label10
            // 
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 0;
            // 
            // label11
            // 
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(100, 23);
            label11.TabIndex = 0;
            // 
            // label12
            // 
            label12.Location = new Point(0, 0);
            label12.Name = "label12";
            label12.Size = new Size(100, 23);
            label12.TabIndex = 0;
            // 
            // label14
            // 
            label14.Location = new Point(0, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 23);
            label14.TabIndex = 0;
            // 
            // label16
            // 
            label16.Location = new Point(0, 0);
            label16.Name = "label16";
            label16.Size = new Size(100, 23);
            label16.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(0, 0);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            // 
            // button5
            // 
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 0;
            // 
            // button6
            // 
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(330, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(955, 567);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 32);
            label1.Name = "label1";
            label1.Size = new Size(89, 19);
            label1.TabIndex = 1;
            label1.Text = "ID Producto";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProducto.Location = new Point(463, 26);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(251, 25);
            txtIdProducto.TabIndex = 2;
            txtIdProducto.TextChanged += txtIdProducto_TextChanged;
            txtIdProducto.KeyPress += txtIdProducto_KeyPress;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(988, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(99, 39);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarTodos.Location = new Point(1127, 26);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(158, 34);
            btnMostrarTodos.TabIndex = 4;
            btnMostrarTodos.Text = "Mostrar Todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(627, 732);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 39);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Location = new Point(772, 735);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 36);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(913, 732);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(108, 36);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // cmbCategorias
            // 
            cmbCategorias.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategorias.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(463, 62);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(251, 25);
            cmbCategorias.TabIndex = 8;
            cmbCategorias.SelectedIndexChanged += cmbCategorias_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 62);
            label2.Name = "label2";
            label2.Size = new Size(79, 19);
            label2.TabIndex = 9;
            label2.Text = "Categoría:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label15);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnReportes);
            panel1.Controls.Add(btnCerrarSesion);
            panel1.Controls.Add(btnDashBoard);
            panel1.Controls.Add(btnControles);
            panel1.Controls.Add(btnGestiones);
            panel1.Controls.Add(btnInicio);
            panel1.Location = new Point(2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(288, 858);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(45, 678);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(197, 24);
            label15.TabIndex = 11;
            label15.Text = "_________________";
            label15.Click += label15_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(45, 277);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(197, 24);
            label13.TabIndex = 12;
            label13.Text = "_________________";
            label13.Click += label13_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(45, 172);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(197, 24);
            label7.TabIndex = 11;
            label7.Text = "_________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.InactiveCaption;
            label3.Location = new Point(96, 136);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 19);
            label3.TabIndex = 10;
            label3.Text = "NORTHWIND";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.InactiveCaption;
            label4.Location = new Point(84, 59);
            label4.Margin = new Padding(4, 0, 4, 0);
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
            label5.Location = new Point(84, 91);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(124, 21);
            label5.TabIndex = 8;
            label5.Text = "DE SOFTWARE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.InactiveCaption;
            label6.Location = new Point(58, 27);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(166, 21);
            label6.TabIndex = 7;
            label6.Text = "IMPLEMENTACIÓN ";
            // 
            // btnReportes
            // 
            btnReportes.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleLeft;
            btnReportes.Location = new Point(14, 507);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(262, 60);
            btnReportes.TabIndex = 5;
            btnReportes.Text = "REPORTES";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCerrarSesion.Image = (Image)resources.GetObject("btnCerrarSesion.Image");
            btnCerrarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.Location = new Point(14, 735);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(259, 55);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "CERRAR SESÍON";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            // 
            // btnDashBoard
            // 
            btnDashBoard.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnDashBoard.Image = (Image)resources.GetObject("btnDashBoard.Image");
            btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new Point(14, 604);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(262, 60);
            btnDashBoard.TabIndex = 3;
            btnDashBoard.Text = "DASHBOARD";
            btnDashBoard.UseVisualStyleBackColor = true;
            // 
            // btnControles
            // 
            btnControles.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnControles.Image = (Image)resources.GetObject("btnControles.Image");
            btnControles.ImageAlign = ContentAlignment.MiddleLeft;
            btnControles.Location = new Point(14, 403);
            btnControles.Name = "btnControles";
            btnControles.Size = new Size(262, 60);
            btnControles.TabIndex = 2;
            btnControles.Text = "CONTROLES";
            btnControles.UseVisualStyleBackColor = true;
            // 
            // btnGestiones
            // 
            btnGestiones.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGestiones.Image = (Image)resources.GetObject("btnGestiones.Image");
            btnGestiones.ImageAlign = ContentAlignment.MiddleLeft;
            btnGestiones.Location = new Point(11, 312);
            btnGestiones.Name = "btnGestiones";
            btnGestiones.Size = new Size(262, 62);
            btnGestiones.TabIndex = 1;
            btnGestiones.Text = "GESTIONES";
            btnGestiones.UseVisualStyleBackColor = true;
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(11, 222);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(262, 52);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "INICIO";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1328, 842);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(cmbCategorias);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEditar);
            Controls.Add(btnMostrarTodos);
            Controls.Add(btnBuscar);
            Controls.Add(txtIdProducto);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmProductos";
            Text = "Productos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtIdProducto;
        private Button btnBuscar;
        private Button btnMostrarTodos;
        private Button btnEditar;
        private Button btnAgregar;
        private Button btnEliminar;
        private ComboBox cmbCategorias;
        private Label label2;
        private Panel panel1;

        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label14;
        private Label label16;

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button btnReportes;
        private Button btnCerrarSesion;
        private Button btnDashBoard;
        private Button btnControles;
        private Button btnGestiones;
        private Button btnInicio;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label13;
        private Label label15;
    }
}
