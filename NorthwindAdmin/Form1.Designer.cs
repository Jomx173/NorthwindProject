namespace NorthwindAdmin
{
    partial class Form1
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

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblPedidoId = new Label();
            txtPedidoId = new TextBox();
            btnBuscarPedido = new Button();
            btnNuevoPedido = new Button();
            lblEstadoPedido = new Label();
            lblCliente = new Label();
            cmbCliente = new ComboBox();
            lblEmpleado = new Label();
            cmbEmpleado = new ComboBox();
            lblProducto = new Label();
            cmbProducto = new ComboBox();
            lblCantidadTexto = new Label();
            txtCantidad = new TextBox();
            lblDescuentoTexto = new Label();
            txtDescuento = new TextBox();
            btnAgregarProducto = new Button();
            btnQuitarProducto = new Button();
            btnGuardarPedido = new Button();
            dgvDetalle = new DataGridView();
            lblSubtotalTexto = new Label();
            lblSubtotal = new Label();
            lblDescuentoTotalTexto = new Label();
            lblDescuento = new Label();
            lblTotalTexto = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitulo.Location = new Point(36, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Gestión de Pedidos";
            // 
            // lblPedidoId
            // 
            lblPedidoId.AutoSize = true;
            lblPedidoId.Font = new Font("Segoe UI", 10F);
            lblPedidoId.Location = new Point(86, 84);
            lblPedidoId.Name = "lblPedidoId";
            lblPedidoId.Size = new Size(84, 23);
            lblPedidoId.TabIndex = 1;
            lblPedidoId.Text = "ID Pedido";
            // 
            // txtPedidoId
            // 
            txtPedidoId.Location = new Point(184, 81);
            txtPedidoId.Name = "txtPedidoId";
            txtPedidoId.Size = new Size(170, 27);
            txtPedidoId.TabIndex = 2;
            // 
            // btnBuscarPedido
            // 
            btnBuscarPedido.Location = new Point(377, 75);
            btnBuscarPedido.Name = "btnBuscarPedido";
            btnBuscarPedido.Size = new Size(135, 39);
            btnBuscarPedido.TabIndex = 3;
            btnBuscarPedido.Text = "Buscar Pedido";
            btnBuscarPedido.UseVisualStyleBackColor = true;
            btnBuscarPedido.Click += btnBuscarPedido_Click;
            // 
            // btnNuevoPedido
            // 
            btnNuevoPedido.Location = new Point(530, 75);
            btnNuevoPedido.Name = "btnNuevoPedido";
            btnNuevoPedido.Size = new Size(135, 39);
            btnNuevoPedido.TabIndex = 4;
            btnNuevoPedido.Text = "Nuevo Pedido";
            btnNuevoPedido.UseVisualStyleBackColor = true;
            btnNuevoPedido.Click += btnNuevoPedido_Click;
            // 
            // lblEstadoPedido
            // 
            lblEstadoPedido.AutoSize = true;
            lblEstadoPedido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoPedido.Location = new Point(696, 84);
            lblEstadoPedido.Name = "lblEstadoPedido";
            lblEstadoPedido.Size = new Size(118, 23);
            lblEstadoPedido.TabIndex = 5;
            lblEstadoPedido.Text = "Pedido nuevo";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new Font("Segoe UI", 10F);
            lblCliente.Location = new Point(106, 139);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(63, 23);
            lblCliente.TabIndex = 6;
            lblCliente.Text = "Cliente";
            // 
            // cmbCliente
            // 
            cmbCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(184, 136);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(305, 28);
            cmbCliente.TabIndex = 7;
            // 
            // lblEmpleado
            // 
            lblEmpleado.AutoSize = true;
            lblEmpleado.Font = new Font("Segoe UI", 10F);
            lblEmpleado.Location = new Point(534, 139);
            lblEmpleado.Name = "lblEmpleado";
            lblEmpleado.Size = new Size(86, 23);
            lblEmpleado.TabIndex = 8;
            lblEmpleado.Text = "Empleado";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(641, 136);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(245, 28);
            cmbEmpleado.TabIndex = 9;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Font = new Font("Segoe UI", 10F);
            lblProducto.Location = new Point(90, 196);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(80, 23);
            lblProducto.TabIndex = 10;
            lblProducto.Text = "Producto";
            // 
            // cmbProducto
            // 
            cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(184, 193);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(305, 28);
            cmbProducto.TabIndex = 11;
            // 
            // lblCantidadTexto
            // 
            lblCantidadTexto.AutoSize = true;
            lblCantidadTexto.Font = new Font("Segoe UI", 10F);
            lblCantidadTexto.Location = new Point(546, 196);
            lblCantidadTexto.Name = "lblCantidadTexto";
            lblCantidadTexto.Size = new Size(79, 23);
            lblCantidadTexto.TabIndex = 12;
            lblCantidadTexto.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(641, 193);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(92, 27);
            txtCantidad.TabIndex = 13;
            // 
            // lblDescuentoTexto
            // 
            lblDescuentoTexto.AutoSize = true;
            lblDescuentoTexto.Font = new Font("Segoe UI", 10F);
            lblDescuentoTexto.Location = new Point(762, 196);
            lblDescuentoTexto.Name = "lblDescuentoTexto";
            lblDescuentoTexto.Size = new Size(92, 23);
            lblDescuentoTexto.TabIndex = 14;
            lblDescuentoTexto.Text = "Desc. 0 a 1";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(886, 193);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(80, 27);
            txtDescuento.TabIndex = 15;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Location = new Point(1000, 181);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(159, 45);
            btnAgregarProducto.TabIndex = 16;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnQuitarProducto
            // 
            btnQuitarProducto.Location = new Point(1180, 181);
            btnQuitarProducto.Name = "btnQuitarProducto";
            btnQuitarProducto.Size = new Size(128, 45);
            btnQuitarProducto.TabIndex = 17;
            btnQuitarProducto.Text = "Quitar";
            btnQuitarProducto.UseVisualStyleBackColor = true;
            btnQuitarProducto.Click += btnQuitarProducto_Click;
            // 
            // btnGuardarPedido
            // 
            btnGuardarPedido.Location = new Point(1100, 643);
            btnGuardarPedido.Name = "btnGuardarPedido";
            btnGuardarPedido.Size = new Size(208, 52);
            btnGuardarPedido.TabIndex = 18;
            btnGuardarPedido.Text = "Guardar Pedido";
            btnGuardarPedido.UseVisualStyleBackColor = true;
            btnGuardarPedido.Click += btnGuardarPedido_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(86, 252);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.RowHeadersWidth = 51;
            dgvDetalle.Size = new Size(1222, 355);
            dgvDetalle.TabIndex = 19;
            // 
            // lblSubtotalTexto
            // 
            lblSubtotalTexto.AutoSize = true;
            lblSubtotalTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotalTexto.Location = new Point(792, 625);
            lblSubtotalTexto.Name = "lblSubtotalTexto";
            lblSubtotalTexto.Size = new Size(84, 23);
            lblSubtotalTexto.TabIndex = 20;
            lblSubtotalTexto.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Font = new Font("Segoe UI", 10F);
            lblSubtotal.Location = new Point(905, 625);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(19, 23);
            lblSubtotal.TabIndex = 21;
            lblSubtotal.Text = "0";
            // 
            // lblDescuentoTotalTexto
            // 
            lblDescuentoTotalTexto.AutoSize = true;
            lblDescuentoTotalTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDescuentoTotalTexto.Location = new Point(763, 660);
            lblDescuentoTotalTexto.Name = "lblDescuentoTotalTexto";
            lblDescuentoTotalTexto.Size = new Size(98, 23);
            lblDescuentoTotalTexto.TabIndex = 22;
            lblDescuentoTotalTexto.Text = "Descuento:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Segoe UI", 10F);
            lblDescuento.Location = new Point(905, 660);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(19, 23);
            lblDescuento.TabIndex = 23;
            lblDescuento.Text = "0";
            // 
            // lblTotalTexto
            // 
            lblTotalTexto.AutoSize = true;
            lblTotalTexto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotalTexto.Location = new Point(809, 695);
            lblTotalTexto.Name = "lblTotalTexto";
            lblTotalTexto.Size = new Size(60, 25);
            lblTotalTexto.TabIndex = 24;
            lblTotalTexto.Text = "Total:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTotal.Location = new Point(905, 695);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(23, 25);
            lblTotal.TabIndex = 25;
            lblTotal.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1390, 745);
            Controls.Add(lblTotal);
            Controls.Add(lblTotalTexto);
            Controls.Add(lblDescuento);
            Controls.Add(lblDescuentoTotalTexto);
            Controls.Add(lblSubtotal);
            Controls.Add(lblSubtotalTexto);
            Controls.Add(dgvDetalle);
            Controls.Add(btnGuardarPedido);
            Controls.Add(btnQuitarProducto);
            Controls.Add(btnAgregarProducto);
            Controls.Add(txtDescuento);
            Controls.Add(lblDescuentoTexto);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidadTexto);
            Controls.Add(cmbProducto);
            Controls.Add(lblProducto);
            Controls.Add(cmbEmpleado);
            Controls.Add(lblEmpleado);
            Controls.Add(cmbCliente);
            Controls.Add(lblCliente);
            Controls.Add(lblEstadoPedido);
            Controls.Add(btnNuevoPedido);
            Controls.Add(btnBuscarPedido);
            Controls.Add(txtPedidoId);
            Controls.Add(lblPedidoId);
            Controls.Add(lblTitulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestion de pedidos";
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblPedidoId;
        private TextBox txtPedidoId;
        private Button btnBuscarPedido;
        private Button btnNuevoPedido;
        private Label lblEstadoPedido;
        private Label lblCliente;
        private ComboBox cmbCliente;
        private Label lblEmpleado;
        private ComboBox cmbEmpleado;
        private Label lblProducto;
        private ComboBox cmbProducto;
        private Label lblCantidadTexto;
        private TextBox txtCantidad;
        private Label lblDescuentoTexto;
        private TextBox txtDescuento;
        private Button btnAgregarProducto;
        private Button btnQuitarProducto;
        private Button btnGuardarPedido;
        private DataGridView dgvDetalle;
        private Label lblSubtotalTexto;
        private Label lblSubtotal;
        private Label lblDescuentoTotalTexto;
        private Label lblDescuento;
        private Label lblTotalTexto;
        private Label lblTotal;
    }
}
