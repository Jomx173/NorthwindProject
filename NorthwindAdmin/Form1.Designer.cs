<<<<<<< HEAD
﻿namespace NorthwindAdmin
=======
using System.Windows.Forms;
using System.Drawing;

namespace NorthwindAdmin
>>>>>>> origin/GestionProveedores
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

<<<<<<< HEAD
=======
        // Paneles contenedores principales
        private Panel panelSidebar;
        private Panel panelContenido;

        // Componente para almacenar los iconos de forma nativa
        private ImageList imageListMenu;

        // Elementos de la barra lateral
        private Label lblSidebarTitle;

        // Elementos del área de contenido
        private Label lblMainTitle;
        private Label lblSubtitle;
        private DataGridView dgvProveedores;

        // Cajas de texto (Inputs)
        private TextBox txtId;
        private TextBox txtEmpresa;
        private TextBox txtContacto;
        private TextBox txtPais;
        private TextBox txtTelefono;

        // Etiquetas de las cajas de texto
        private Label lblId;
        private Label lblEmpresa;
        private Label lblContacto;
        private Label lblPais;
        private Label lblTelefono;

        // Botones de acción
        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Button btnActualizar;

>>>>>>> origin/GestionProveedores
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

<<<<<<< HEAD
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
=======
        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SuspendLayout();

            // =========================================================================
            // CONFIGURACIÓN DE LA VENTANA PRINCIPAL
            // =========================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800); // Se amplió ligeramente el lienzo base para mayor holgura
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte de Ventas por Cliente - Módulo Proveedores";

            // =========================================================================
            // PANEL LATERAL (SIDEBAR - AZUL OSCURO)
            // =========================================================================
            this.panelSidebar = new Panel();
            this.panelSidebar.Width = 240;
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.BackColor = Color.FromArgb(17, 29, 122);
            this.Controls.Add(this.panelSidebar);

            // Título superior del Sidebar
            this.lblSidebarTitle = new Label();
            this.lblSidebarTitle.Text = "IMPLEMENTACIÓN\nDE SISTEMAS\nDE SOFTWARE\n\nNORTHWIND";
            this.lblSidebarTitle.Font = new Font("Segoe UI", 11, FontStyle.Bold | FontStyle.Italic);
            this.lblSidebarTitle.ForeColor = Color.White;
            this.lblSidebarTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblSidebarTitle.Dock = DockStyle.Top;
            this.lblSidebarTitle.Height = 160;
            this.panelSidebar.Controls.Add(this.lblSidebarTitle);

            // =========================================================================
            // CONFIGURACIÓN DE ICONOS (IMAGELIST DESDE CARPETA LOCAL)
            // =========================================================================
            this.imageListMenu = new ImageList(this.components);
            this.imageListMenu.ImageSize = new Size(24, 24);
            this.imageListMenu.ColorDepth = ColorDepth.Depth32Bit;

            try
            {
                this.imageListMenu.Images.Add("inicio", Image.FromFile("Resources/ico_inicio.png"));
                this.imageListMenu.Images.Add("gestiones", Image.FromFile("Resources/ico_gestiones.png"));
                this.imageListMenu.Images.Add("controles", Image.FromFile("Resources/ico_controles.png"));
                this.imageListMenu.Images.Add("reportes", Image.FromFile("Resources/ico_reportes.png"));
                this.imageListMenu.Images.Add("dashboard", Image.FromFile("Resources/ico_dashboard.png"));
                this.imageListMenu.Images.Add("cerrar", Image.FromFile("Resources/ico_cerrar.png"));
            }
            catch
            {
                // Previene caídas si un archivo falta temporalmente
            }

            // Construcción del menú vertical automático
            string[] itemsMenu = { "INICIO", "GESTIONES", "CONTROLES", "REPORTES", "DASHBOARD", "CERRAR SESIÓN" };
            string[] llavesImagenes = { "inicio", "gestiones", "controles", "reportes", "dashboard", "cerrar" };
            int startButtonY = 170;

            for (int i = 0; i < itemsMenu.Length; i++)
            {
                Button btnMenu = new Button();
                btnMenu.Text = itemsMenu[i];
                btnMenu.Location = new Point(15, startButtonY);
                btnMenu.Width = 210;
                btnMenu.Height = 45;
                btnMenu.FlatStyle = FlatStyle.Flat;
                btnMenu.FlatAppearance.BorderSize = 0;
                btnMenu.BackColor = Color.White;
                btnMenu.ForeColor = Color.Black;
                btnMenu.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                btnMenu.ImageList = this.imageListMenu;
                btnMenu.ImageKey = llavesImagenes[i];
                btnMenu.ImageAlign = ContentAlignment.MiddleLeft;
                btnMenu.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnMenu.Padding = new Padding(10, 0, 0, 0);

                this.panelSidebar.Controls.Add(btnMenu);
                startButtonY += 55;
            }

            // =========================================================================
            // PANEL DE CONTENIDO PRINCIPAL (GRIS CLARO)
            // =========================================================================
            this.panelContenido = new Panel();
            this.panelContenido.Dock = DockStyle.Fill;
            this.panelContenido.BackColor = Color.FromArgb(244, 245, 247);
            this.Controls.Add(this.panelContenido);
            this.panelContenido.BringToFront();

            // =========================================================================
            // COMPONENTES INTERNOS DEL PANEL DE CONTENIDO
            // =========================================================================

            this.lblMainTitle = new Label();
            this.lblMainTitle.Text = "Administración de Proveedores";
            this.lblMainTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            this.lblMainTitle.Location = new Point(30, 20);
            this.lblMainTitle.AutoSize = true;
            this.panelContenido.Controls.Add(this.lblMainTitle);

            this.lblSubtitle = new Label();
            this.lblSubtitle.Text = "Gestión operativa, actualización y filtrado geográfico de proveedores basados en Northwind.";
            this.lblSubtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.lblSubtitle.ForeColor = Color.Gray;
            this.lblSubtitle.Location = new Point(35, 65);
            this.lblSubtitle.AutoSize = true;
            this.panelContenido.Controls.Add(this.lblSubtitle);

            // ENTRADAS DE DATOS (INPUTS LINEALES)
            int topRow = 115;

            this.lblId = new Label { Text = "ID", Location = new Point(30, topRow), AutoSize = true, Font = new Font("Segoe UI", 9) };
            this.txtId = new TextBox { Location = new Point(30, topRow + 22), Width = 90, Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle, ReadOnly = true, BackColor = Color.FromArgb(225, 228, 233) };

            this.lblEmpresa = new Label { Text = "Empresa *", Location = new Point(140, topRow), AutoSize = true, Font = new Font("Segoe UI", 9) };
            this.txtEmpresa = new TextBox { Location = new Point(140, topRow + 22), Width = 230, Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle };

            this.lblContacto = new Label { Text = "Contacto", Location = new Point(390, topRow), AutoSize = true, Font = new Font("Segoe UI", 9) };
            this.txtContacto = new TextBox { Location = new Point(390, topRow + 22), Width = 200, Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle };

            this.lblPais = new Label { Text = "País (Filtro)", Location = new Point(610, topRow), AutoSize = true, Font = new Font("Segoe UI", 9) };
            this.txtPais = new TextBox { Location = new Point(610, topRow + 22), Width = 150, Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle };

            this.lblTelefono = new Label { Text = "Teléfono", Location = new Point(780, topRow), AutoSize = true, Font = new Font("Segoe UI", 9) };
            this.txtTelefono = new TextBox { Location = new Point(780, topRow + 22), Width = 150, Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle };

            this.panelContenido.Controls.AddRange(new Control[] { lblId, txtId, lblEmpresa, txtEmpresa, lblContacto, txtContacto, lblPais, txtPais, lblTelefono, txtTelefono });

            // BOTONES DE ACCIÓN 
            int btnRow = topRow + 65;

            this.btnBuscar = new Button { Text = "Buscar País", Location = new Point(30, btnRow), Width = 130, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = Color.White, ForeColor = Color.Black, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            this.btnBuscar.FlatAppearance.BorderColor = Color.LightGray;

            this.btnLimpiar = new Button { Text = "Limpiar", Location = new Point(170, btnRow), Width = 110, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = Color.White, ForeColor = Color.Black, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            this.btnLimpiar.FlatAppearance.BorderColor = Color.LightGray;

            this.btnRegistrar = new Button { Text = "Registrar Proveedor", Location = new Point(290, btnRow), Width = 180, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(40, 167, 69), ForeColor = Color.White, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            this.btnRegistrar.FlatAppearance.BorderSize = 0;

            this.btnActualizar = new Button { Text = "Actualizar Cambios", Location = new Point(480, btnRow), Width = 180, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(0, 123, 255), ForeColor = Color.White, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            this.btnActualizar.FlatAppearance.BorderSize = 0;

            this.panelContenido.Controls.AddRange(new Control[] { btnBuscar, btnLimpiar, btnRegistrar, btnActualizar });

            // DATAGRIDVIEW OPTIMIZADO (LLENADO AUTOMÁTICO DEL ESPACIO INFERIOR)
            this.dgvProveedores = new DataGridView();

            // En lugar de coordenadas fijas, acoplamos la tabla al fondo del panel contenedor
            this.dgvProveedores.Dock = DockStyle.Bottom;
            this.dgvProveedores.Height = 500; // Esto controla qué tan alta se verá en pantalla

            this.dgvProveedores.BackgroundColor = Color.White;
            this.dgvProveedores.BorderStyle = BorderStyle.None;
            this.dgvProveedores.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProveedores.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvProveedores.EnableHeadersVisualStyles = false;

            this.dgvProveedores.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 237, 240);
            this.dgvProveedores.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.dgvProveedores.ColumnHeadersHeight = 40;

            this.dgvProveedores.DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Regular);

            // Ajuste de color de selección contrastado
            this.dgvProveedores.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 225, 250);
            this.dgvProveedores.DefaultCellStyle.SelectionForeColor = Color.Black;

            this.dgvProveedores.RowTemplate.Height = 35;

            // Combinación perfecta: Rellena el ancho total y permite scroll si hay muchas columnas
            this.dgvProveedores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProveedores.ScrollBars = ScrollBars.Both;

            this.dgvProveedores.AllowUserToAddRows = false;
            this.dgvProveedores.ReadOnly = true;
            this.dgvProveedores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvProveedores.MultiSelect = false;

            this.panelContenido.Controls.Add(this.dgvProveedores);
            // VINCULACIÓN CON EVENTOS
            this.Load += new System.EventHandler(this.Form1_Load);
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            this.dgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellClick);

            this.ResumeLayout(false);
        }

        #endregion
    }
}
>>>>>>> origin/GestionProveedores
