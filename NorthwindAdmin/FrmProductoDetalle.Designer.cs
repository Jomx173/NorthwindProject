namespace NorthwindAdmin
{
    partial class FrmProductoDetalle
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
            label1 = new Label();
            txtIdProducto = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            txtPrecio = new TextBox();
            txtStock = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnGuardar = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "ID Producto :";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(135, 24);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(164, 31);
            txtIdProducto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(446, 27);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            //  
            // txtNombre
            // 
            txtNombre.Location = new Point(545, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(164, 31);
            txtNombre.TabIndex = 3;
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(135, 117);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(164, 31);
            txtPrecio.TabIndex = 4;
            txtPrecio.KeyPress += txtPrecio_KeyPress;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(545, 117);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(164, 31);
            txtStock.TabIndex = 5;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 7;
            label3.Text = "Precio :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(371, 120);
            label4.Name = "label4";
            label4.Size = new Size(168, 25);
            label4.TabIndex = 8;
            label4.Text = "Unidades de Stock :";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(228, 216);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(412, 216);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(112, 34);
            BtnCancelar.TabIndex = 10;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += btnCancelar_Click;
            // 
            // FrmProductoDetalle
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 283);
            Controls.Add(BtnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtStock);
            Controls.Add(txtPrecio);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtIdProducto);
            Controls.Add(label1);
            Name = "FrmProductoDetalle";
            Text = "FrmProductoDetalle";
            Load += FrmProductoDetalle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdProducto;
        private Label label2;
        private TextBox txtNombre;
        private TextBox txtPrecio;
        private TextBox txtStock;
        private Label label3;
        private Label label4;
        private Button btnGuardar;
        private Button BtnCancelar;
    }
}