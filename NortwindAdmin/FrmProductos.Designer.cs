namespace NortwindAdmin
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(317, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(735, 414);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(308, 32);
            label1.Name = "label1";
            label1.Size = new Size(125, 28);
            label1.TabIndex = 1;
            label1.Text = "ID Producto";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Font = new Font("Nirmala UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdProducto.Location = new Point(463, 26);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(212, 31);
            txtIdProducto.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(712, 23);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(99, 39);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(833, 23);
            btnMostrarTodos.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(158, 34);
            btnMostrarTodos.TabIndex = 4;
            btnMostrarTodos.Text = "Mostrar Todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(368, 556);
            btnEditar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(99, 39);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(490, 556);
            btnAgregar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 37);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(615, 559);
            btnEliminar.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 34);
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
            cmbCategorias.Size = new Size(182, 33);
            cmbCategorias.TabIndex = 8;
            cmbCategorias.SelectedIndexChanged += cmbCategorias_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(308, 62);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 9;
            label2.Text = "Categoría:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkBlue;
            panel1.Location = new Point(2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 688);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 678);
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
    }
}
