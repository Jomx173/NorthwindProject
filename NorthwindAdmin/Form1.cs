<<<<<<< HEAD
﻿using DataAccces.Context;
using DataAccces.Models;
=======
using System;
using System.Windows.Forms;
using ProyectoProveedores;
using MiProveedor = Domain.Supplier;
>>>>>>> origin/GestionProveedores

namespace NorthwindAdmin
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        private readonly NorthwindContext db = new NorthwindContext();

        private DataGridView dgvPedidos = new DataGridView();
        private Label lblPedidosExistentes = new Label();
        private Button btnMostrarPedidos = new Button();
        private Panel panelIzquierdo = new Panel();

        private int? pedidoActualId = null;
        private decimal subtotal = 0;
        private decimal descuentoTotal = 0;
        private decimal total = 0;
=======
        private readonly SupplierServices _supplierServices;
>>>>>>> origin/GestionProveedores

        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
            ConfigurarSeccionPedidosExistentes();
            CargarDatos();
            AplicarDisenoInstitucional();
        }

        private void AplicarDisenoInstitucional()
        {
            // Estándar visual solicitado por el catedrático.
            // Se modifica solamente presentación: no se cambia la lógica del módulo.
            Color fondoFormulario = Color.FromArgb(240, 240, 240);   // #F0F0F0
            Color azulPanel = Color.FromArgb(25, 25, 111);           // #19196F
            Color azulEncabezado = Color.FromArgb(25, 25, 111);      // #19196F
            Color azulAcento = Color.FromArgb(0, 120, 215);          // #0078D7
            Color textoTabla = Color.FromArgb(47, 79, 79);           // #2F4F4F
            Color grisGrid = Color.FromArgb(221, 221, 221);          // #DDDDDD
            Color filaAlterna = Color.FromArgb(245, 245, 245);       // #F5F5F5

            Text = "Gestión de Pedidos - Northwind";
            BackColor = fondoFormulario;
            FormBorderStyle = FormBorderStyle.Sizable;
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1375, 790);
            MinimumSize = new Size(1375, 830);
            WindowState = FormWindowState.Maximized;

            // Panel lateral según la referencia enviada.
            ConfigurarPanelIzquierdo(azulPanel);

            // Área principal: inicia después del panel azul.
            int contenidoX = 312;

            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = azulPanel;
            lblTitulo.Location = new Point(contenidoX, 55);
            lblTitulo.Text = "Gestión de Pedidos";

            Label lblDescripcion = Controls.Find("lblDescripcionModulo", true).FirstOrDefault() as Label ?? new Label();
            lblDescripcion.Name = "lblDescripcionModulo";
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            lblDescripcion.ForeColor = Color.FromArgb(35, 35, 35);
            lblDescripcion.Text = "Administración de órdenes de compra realizadas por los clientes.";
            lblDescripcion.Location = new Point(contenidoX, 95);
            if (!Controls.Contains(lblDescripcion)) Controls.Add(lblDescripcion);

            lblEstadoPedido.ForeColor = azulPanel;
            lblEstadoPedido.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            EstilizarBoton(btnBuscarPedido);
            EstilizarBoton(btnNuevoPedido);
            EstilizarBoton(btnMostrarPedidos);
            EstilizarBoton(btnAgregarProducto);
            EstilizarBoton(btnQuitarProducto);
            EstilizarBoton(btnGuardarPedido);

            EstilizarTabla(dgvPedidos, azulEncabezado, azulAcento, textoTabla, grisGrid, filaAlterna);
            EstilizarTabla(dgvDetalle, azulEncabezado, azulAcento, textoTabla, grisGrid, filaAlterna);

            // Distribución similar a la referencia: filtros arriba, tablas al centro, totales abajo.
            lblPedidoId.Location = new Point(contenidoX, 145);
            txtPedidoId.Location = new Point(contenidoX + 105, 141);
            txtPedidoId.Size = new Size(170, 27);
            btnBuscarPedido.Location = new Point(contenidoX + 295, 134);
            btnBuscarPedido.Size = new Size(145, 42);
            btnNuevoPedido.Location = new Point(contenidoX + 455, 134);
            btnNuevoPedido.Size = new Size(145, 42);
            lblEstadoPedido.Location = new Point(contenidoX + 630, 145);

            lblCliente.Location = new Point(contenidoX, 195);
            cmbCliente.Location = new Point(contenidoX + 105, 191);
            cmbCliente.Size = new Size(330, 28);
            lblEmpleado.Location = new Point(contenidoX + 480, 195);
            cmbEmpleado.Location = new Point(contenidoX + 590, 191);
            cmbEmpleado.Size = new Size(270, 28);

            lblProducto.Location = new Point(contenidoX, 245);
            cmbProducto.Location = new Point(contenidoX + 105, 241);
            cmbProducto.Size = new Size(330, 28);
            lblCantidadTexto.Location = new Point(contenidoX + 480, 245);
            txtCantidad.Location = new Point(contenidoX + 590, 241);
            txtCantidad.Size = new Size(90, 27);
            lblDescuentoTexto.Location = new Point(contenidoX + 710, 245);
            txtDescuento.Location = new Point(contenidoX + 830, 241);
            txtDescuento.Size = new Size(80, 27);
            btnAgregarProducto.Location = new Point(contenidoX + 940, 232);
            btnAgregarProducto.Size = new Size(165, 45);
            btnQuitarProducto.Location = new Point(contenidoX + 1120, 232);
            btnQuitarProducto.Size = new Size(125, 45);

            lblPedidosExistentes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPedidosExistentes.ForeColor = azulPanel;
            lblPedidosExistentes.Location = new Point(contenidoX, 298);
            btnMostrarPedidos.Location = new Point(contenidoX + 1090, 288);
            btnMostrarPedidos.Size = new Size(155, 42);

            dgvPedidos.Location = new Point(contenidoX, 335);
            dgvPedidos.Size = new Size(1245, 155);

            dgvDetalle.Location = new Point(contenidoX, 525);
            dgvDetalle.Size = new Size(1245, 145);

            // Totales ordenados dentro de una tarjeta para evitar que se monten o se vean desalineados.
            Panel panelTotales = Controls.Find("panelTotalesPedido", true).FirstOrDefault() as Panel ?? new Panel();
            panelTotales.Name = "panelTotalesPedido";
            panelTotales.BackColor = Color.White;
            panelTotales.BorderStyle = BorderStyle.FixedSingle;
            panelTotales.Location = new Point(contenidoX + 690, 675);
            panelTotales.Size = new Size(280, 105);
            if (!Controls.Contains(panelTotales)) Controls.Add(panelTotales);

            lblSubtotalTexto.Parent = panelTotales;
            lblSubtotalTexto.Location = new Point(20, 12);
            lblSubtotalTexto.Size = new Size(110, 24);
            lblSubtotalTexto.TextAlign = ContentAlignment.MiddleRight;
            lblSubtotalTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            lblSubtotal.Parent = panelTotales;
            lblSubtotal.Location = new Point(140, 12);
            lblSubtotal.Size = new Size(120, 24);
            lblSubtotal.TextAlign = ContentAlignment.MiddleRight;
            lblSubtotal.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            lblDescuentoTotalTexto.Parent = panelTotales;
            lblDescuentoTotalTexto.Location = new Point(20, 42);
            lblDescuentoTotalTexto.Size = new Size(110, 24);
            lblDescuentoTotalTexto.TextAlign = ContentAlignment.MiddleRight;
            lblDescuentoTotalTexto.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);

            lblDescuento.Parent = panelTotales;
            lblDescuento.Location = new Point(140, 42);
            lblDescuento.Size = new Size(120, 24);
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            lblDescuento.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);

            lblTotalTexto.Parent = panelTotales;
            lblTotalTexto.Location = new Point(20, 72);
            lblTotalTexto.Size = new Size(110, 24);
            lblTotalTexto.TextAlign = ContentAlignment.MiddleRight;
            lblTotalTexto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            lblTotal.Parent = panelTotales;
            lblTotal.Location = new Point(140, 72);
            lblTotal.Size = new Size(120, 24);
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            lblTotal.ForeColor = azulPanel;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            btnGuardarPedido.Location = new Point(contenidoX + 995, 690);
            btnGuardarPedido.Size = new Size(190, 55);


            panelTotales.BringToFront();
            btnGuardarPedido.BringToFront();
            panelIzquierdo.BringToFront();
        }

        private void ConfigurarPanelIzquierdo(Color azulPanel)
        {
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.BackColor = azulPanel;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Size = new Size(260, ClientSize.Height);
            panelIzquierdo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelIzquierdo.Controls.Clear();

            if (!Controls.Contains(panelIzquierdo))
                Controls.Add(panelIzquierdo);

            Label lblInstitucion = CrearLabelMenu("IMPLEMENTACIÓN\nDE SISTEMAS\nDE SOFTWARE", 20, 28, 13F, true);
            lblInstitucion.TextAlign = ContentAlignment.MiddleCenter;
            lblInstitucion.Size = new Size(220, 90);
            panelIzquierdo.Controls.Add(lblInstitucion);

            Label lblNorthwind = CrearLabelMenu("NORTHWIND", 20, 140, 11F, true);
            lblNorthwind.TextAlign = ContentAlignment.MiddleCenter;
            lblNorthwind.Size = new Size(220, 28);
            panelIzquierdo.Controls.Add(lblNorthwind);

            AgregarLineaMenu(20, 188);

            Button btnInicioMenu = CrearBotonMenu("INICIO", "inicio.png", 20, 205);
            Button btnGestionesMenu = CrearBotonMenu("GESTIONES", "gestiones.png", 20, 305);
            Button btnControlesMenu = CrearBotonMenu("CONTROLES", "controles.png", 20, 375);
            Button btnReportesMenu = CrearBotonMenu("REPORTES", "reportes.png", 20, 445);
            Button btnDashboardMenu = CrearBotonMenu("DASHBOARD", "dashboard.png", 20, 515);
            Button btnCerrarMenu = CrearBotonMenu("CERRAR SESIÓN", "salir.png", 20, ClientSize.Height - 90);
            btnCerrarMenu.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;

            // El módulo actual pertenece a Gestiones.
            btnGestionesMenu.BackColor = Color.White;
            btnGestionesMenu.ForeColor = Color.Black;

            panelIzquierdo.Controls.Add(btnInicioMenu);
            panelIzquierdo.Controls.Add(btnGestionesMenu);
            panelIzquierdo.Controls.Add(btnControlesMenu);
            panelIzquierdo.Controls.Add(btnReportesMenu);
            panelIzquierdo.Controls.Add(btnDashboardMenu);
            panelIzquierdo.Controls.Add(btnCerrarMenu);

            AgregarLineaMenu(20, 275);
            AgregarLineaMenu(20, 585);
        }

        private Label CrearLabelMenu(string texto, int x, int y, float size, bool negrita)
        {
            return new Label
            {
                Text = texto,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", size, negrita ? FontStyle.Bold | FontStyle.Italic : FontStyle.Regular),
                Location = new Point(x, y),
                AutoSize = false,
                BackColor = Color.Transparent
            };
        }

        private void AgregarLineaMenu(int x, int y)
        {
            Panel linea = new Panel
            {
                BackColor = Color.White,
                Location = new Point(x, y),
                Size = new Size(220, 2)
            };
            panelIzquierdo.Controls.Add(linea);
        }

        private Button CrearBotonMenu(string texto, string icono, int x, int y)
        {
            Button boton = new Button
            {
                Text = "  " + texto,
                Location = new Point(x, y),
                Size = new Size(220, 52),
                BackColor = Color.White,
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10.5F, FontStyle.Bold | FontStyle.Italic),
                TextAlign = ContentAlignment.MiddleCenter,
                ImageAlign = ContentAlignment.MiddleLeft,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                Cursor = Cursors.Hand
            };
            boton.FlatAppearance.BorderSize = 0;

            Image? imagen = CargarIconoMenu(icono);
            if (imagen != null)
                boton.Image = new Bitmap(imagen, new Size(38, 38));

            return boton;
        }

        private Image? CargarIconoMenu(string nombreArchivo)
        {
            string[] rutas =
            {
                Path.Combine(AppContext.BaseDirectory, "Iconos ISS", nombreArchivo),
                Path.Combine(Application.StartupPath, "Iconos ISS", nombreArchivo),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Iconos ISS", nombreArchivo),
                Path.Combine(Environment.CurrentDirectory, "Iconos ISS", nombreArchivo)
            };

            foreach (string ruta in rutas)
            {
                if (File.Exists(ruta))
                    return Image.FromFile(ruta);
            }

            return null;
        }

        private void EstilizarBoton(Button boton)
        {
            boton.FlatStyle = FlatStyle.Standard;
            boton.BackColor = Color.White;
            boton.ForeColor = Color.Black;
            boton.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        }

        private void EstilizarTabla(DataGridView tabla, Color encabezado, Color acento, Color texto, Color grid, Color alterna)
        {
            tabla.BackgroundColor = Color.White;
            tabla.GridColor = grid;
            tabla.BorderStyle = BorderStyle.FixedSingle;
            tabla.EnableHeadersVisualStyles = false;
            tabla.ColumnHeadersDefaultCellStyle.BackColor = encabezado;
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            tabla.DefaultCellStyle.BackColor = Color.White;
            tabla.DefaultCellStyle.ForeColor = texto;
            tabla.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 215);
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;
            tabla.AlternatingRowsDefaultCellStyle.BackColor = alterna;
            tabla.RowHeadersVisible = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.ColumnHeadersHeight = 38;

            if (tabla.Columns.Count > 1)
                tabla.Columns[1].HeaderCell.Style.BackColor = acento;
        }

        private void CargarDatos()
        {
            cmbCliente.DataSource = db.Customers.OrderBy(c => c.CompanyName).ToList();
            cmbCliente.DisplayMember = "CompanyName";
            cmbCliente.ValueMember = "CustomerId";

            cmbEmpleado.DataSource = db.Employees.OrderBy(e => e.FirstName).ToList();
            cmbEmpleado.DisplayMember = "FirstName";
            cmbEmpleado.ValueMember = "EmployeeId";

            cmbProducto.DataSource = db.Products.OrderBy(p => p.ProductName).ToList();
            cmbProducto.DisplayMember = "ProductName";
            cmbProducto.ValueMember = "ProductId";

            PrepararTablaDetalle();
            PrepararTablaPedidos();
            CargarPedidosExistentes();
            NuevoPedido();
        }


        private void ConfigurarSeccionPedidosExistentes()
        {
            lblPedidosExistentes.AutoSize = true;
            lblPedidosExistentes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPedidosExistentes.Location = new Point(86, 245);
            lblPedidosExistentes.Name = "lblPedidosExistentes";
            lblPedidosExistentes.Size = new Size(170, 23);
            lblPedidosExistentes.Text = "Pedidos existentes";

            btnMostrarPedidos.Location = new Point(1130, 238);
            btnMostrarPedidos.Name = "btnMostrarPedidos";
            btnMostrarPedidos.Size = new Size(178, 36);
            btnMostrarPedidos.Text = "Mostrar Pedidos";
            btnMostrarPedidos.UseVisualStyleBackColor = true;
            btnMostrarPedidos.Click += btnMostrarPedidos_Click;

            dgvPedidos.BackgroundColor = SystemColors.ControlDark;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(86, 280);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(1222, 170);
            dgvPedidos.TabIndex = 26;
            dgvPedidos.CellDoubleClick += dgvPedidos_CellDoubleClick;

            dgvDetalle.Location = new Point(86, 500);
            dgvDetalle.Size = new Size(1222, 170);

            lblSubtotalTexto.Location = new Point(792, 685);
            lblSubtotal.Location = new Point(905, 685);
            lblDescuentoTotalTexto.Location = new Point(763, 715);
            lblDescuento.Location = new Point(905, 715);
            lblTotalTexto.Location = new Point(809, 745);
            lblTotal.Location = new Point(905, 745);
            btnGuardarPedido.Location = new Point(1100, 700);

            ClientSize = new Size(1390, 790);
            Controls.Add(lblPedidosExistentes);
            Controls.Add(btnMostrarPedidos);
            Controls.Add(dgvPedidos);
        }

        private void PrepararTablaPedidos()
        {
            dgvPedidos.Columns.Clear();
            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.MultiSelect = false;
            dgvPedidos.ReadOnly = true;

            dgvPedidos.Columns.Add("OrderId", "ID Pedido");
            dgvPedidos.Columns.Add("CustomerId", "ID Cliente");
            dgvPedidos.Columns.Add("Cliente", "Cliente");
            dgvPedidos.Columns.Add("Empleado", "Empleado");
            dgvPedidos.Columns.Add("Fecha", "Fecha");
            dgvPedidos.Columns.Add("Productos", "Productos");
            dgvPedidos.Columns.Add("Total", "Total");

            dgvPedidos.Columns["OrderId"].Width = 90;
            dgvPedidos.Columns["CustomerId"].Width = 90;
            dgvPedidos.Columns["Cliente"].Width = 260;
            dgvPedidos.Columns["Empleado"].Width = 180;
            dgvPedidos.Columns["Fecha"].Width = 130;
            dgvPedidos.Columns["Productos"].Width = 110;
            dgvPedidos.Columns["Total"].Width = 130;
        }

        private void CargarPedidosExistentes(int? orderIdFiltro = null)
        {
            dgvPedidos.Rows.Clear();

            var consulta = db.Orders.AsQueryable();

            if (orderIdFiltro.HasValue)
                consulta = consulta.Where(o => o.OrderId == orderIdFiltro.Value);

            var pedidos = consulta
                .OrderByDescending(o => o.OrderId)
                .Take(100)
                .ToList();

            foreach (Order pedido in pedidos)
            {
                var detalles = db.OrderDetails.Where(d => d.OrderId == pedido.OrderId).ToList();
                decimal totalPedido = detalles.Sum(d => d.UnitPrice * d.Quantity * (1 - Convert.ToDecimal(d.Discount)));
                int cantidadProductos = detalles.Sum(d => d.Quantity);
                Customer? cliente = db.Customers.FirstOrDefault(c => c.CustomerId == pedido.CustomerId);
                Employee? empleado = pedido.EmployeeId.HasValue
                    ? db.Employees.FirstOrDefault(e => e.EmployeeId == pedido.EmployeeId.Value)
                    : null;

                string nombreEmpleado = empleado == null ? "" : $"{empleado.FirstName} {empleado.LastName}";

                int rowIndex = dgvPedidos.Rows.Add(
                    pedido.OrderId,
                    pedido.CustomerId,
                    cliente?.CompanyName ?? "",
                    nombreEmpleado,
                    pedido.OrderDate?.ToString("dd/MM/yyyy") ?? "",
                    cantidadProductos,
                    totalPedido.ToString("C")
                );

                dgvPedidos.Rows[rowIndex].Tag = pedido.OrderId;
            }
        }

        private void PrepararTablaDetalle()
        {
            dgvDetalle.Columns.Clear();
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.AllowUserToAddRows = false;
            dgvDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalle.MultiSelect = false;
            dgvDetalle.ReadOnly = true;

            dgvDetalle.Columns.Add("ProductId", "ID Producto");
            dgvDetalle.Columns.Add("Producto", "Producto");
            dgvDetalle.Columns.Add("Precio", "Precio");
            dgvDetalle.Columns.Add("Cantidad", "Cantidad");
            dgvDetalle.Columns.Add("Descuento", "Descuento");
            dgvDetalle.Columns.Add("Subtotal", "Subtotal");

            dgvDetalle.Columns["ProductId"].Width = 90;
            dgvDetalle.Columns["Producto"].Width = 300;
            dgvDetalle.Columns["Precio"].Width = 110;
            dgvDetalle.Columns["Cantidad"].Width = 110;
            dgvDetalle.Columns["Descuento"].Width = 120;
            dgvDetalle.Columns["Subtotal"].Width = 130;
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPedidoId.Text, out int orderId) || orderId <= 0)
            {
                MessageBox.Show("Ingrese un ID de pedido válido.");
                txtPedidoId.Focus();
                return;
            }

            CargarPedidosExistentes(orderId);
            CargarPedidoExistente(orderId);
        }


        private void btnMostrarPedidos_Click(object? sender, EventArgs e)
        {
            txtPedidoId.Clear();
            CargarPedidosExistentes();
        }

        private void dgvPedidos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dgvPedidos.Rows[e.RowIndex].Tag is int orderId)
            {
                txtPedidoId.Text = orderId.ToString();
                CargarPedidoExistente(orderId);
            }
        }

        private void CargarPedidoExistente(int orderId)
        {
            Order? pedido = db.Orders.FirstOrDefault(o => o.OrderId == orderId);

            if (pedido == null)
            {
                MessageBox.Show("No se encontró un pedido con ese ID.");
                return;
            }

            pedidoActualId = pedido.OrderId;
            lblEstadoPedido.Text = $"Pedido cargado: #{pedido.OrderId}";
            btnGuardarPedido.Text = "Actualizar Pedido";

            if (!string.IsNullOrWhiteSpace(pedido.CustomerId))
                cmbCliente.SelectedValue = pedido.CustomerId;

            if (pedido.EmployeeId.HasValue)
                cmbEmpleado.SelectedValue = pedido.EmployeeId.Value;

            dgvDetalle.Rows.Clear();
            ReiniciarTotales(false);

            var detalles = db.OrderDetails
                .Where(d => d.OrderId == orderId)
                .ToList();

            foreach (OrderDetail detalle in detalles)
            {
                Product? producto = db.Products.FirstOrDefault(p => p.ProductId == detalle.ProductId);
                string nombreProducto = producto?.ProductName ?? "Producto sin nombre";

                AgregarFilaDetalle(
                    detalle.ProductId,
                    nombreProducto,
                    detalle.UnitPrice,
                    detalle.Quantity,
                    Convert.ToDecimal(detalle.Discount)
                );
            }

            MostrarTotales();
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            NuevoPedido();
        }

        private void NuevoPedido()
        {
            pedidoActualId = null;
            txtPedidoId.Clear();
            dgvDetalle.Rows.Clear();
            lblEstadoPedido.Text = "Pedido nuevo";
            btnGuardarPedido.Text = "Guardar Pedido";
            ReiniciarTotales(true);
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cmbCliente.SelectedItem == null || cmbEmpleado.SelectedItem == null || cmbProducto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione cliente, empleado y producto.");
                return;
            }

            if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor que 0.");
                txtCantidad.Focus();
                return;
            }

            if (!decimal.TryParse(txtDescuento.Text, out decimal descuento))
            {
                MessageBox.Show("Ingrese un descuento válido. Ejemplo: 0.10 para 10%.");
                txtDescuento.Focus();
                return;
            }

            if (descuento < 0 || descuento > 1)
            {
                MessageBox.Show("El descuento debe estar entre 0 y 1. Ejemplo: 0.15 = 15%.");
                txtDescuento.Focus();
                return;
            }

            Product producto = (Product)cmbProducto.SelectedItem;
            decimal precio = producto.UnitPrice ?? 0;

            AgregarFilaDetalle(producto.ProductId, producto.ProductName, precio, cantidad, descuento);

            txtCantidad.Clear();
            txtDescuento.Text = "0";
        }

        private void AgregarFilaDetalle(int productId, string productName, decimal precio, int cantidad, decimal descuento)
        {
            decimal sub = precio * cantidad;
            decimal desc = sub * descuento;
            decimal totalLinea = sub - desc;

            dgvDetalle.Rows.Add(
                productId,
                productName,
                precio.ToString("C"),
                cantidad,
                descuento.ToString("P0"),
                totalLinea.ToString("C")
            );

            dgvDetalle.Rows[dgvDetalle.Rows.Count - 1].Tag = new DetallePedidoTemporal
            {
                ProductId = productId,
                UnitPrice = precio,
                Quantity = cantidad,
                Discount = descuento
            };

            subtotal += sub;
            descuentoTotal += desc;
            total += totalLinea;
            MostrarTotales();
        }

        private void btnGuardarPedido_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto antes de guardar el pedido.");
                return;
            }

            Order pedido;

            if (pedidoActualId.HasValue)
            {
                pedido = db.Orders.First(o => o.OrderId == pedidoActualId.Value);
                pedido.CustomerId = cmbCliente.SelectedValue?.ToString();
                pedido.EmployeeId = Convert.ToInt32(cmbEmpleado.SelectedValue);

                var detallesAnteriores = db.OrderDetails
                    .Where(d => d.OrderId == pedidoActualId.Value)
                    .ToList();

                db.OrderDetails.RemoveRange(detallesAnteriores);

                // Primero se eliminan los detalles anteriores en la base de datos.
                // Esto evita el error de Entity Framework cuando se vuelve a agregar
                // un OrderDetail con la misma llave compuesta OrderId + ProductId.
                db.SaveChanges();
            }
            else
            {
                pedido = new Order
                {
                    CustomerId = cmbCliente.SelectedValue?.ToString(),
                    EmployeeId = Convert.ToInt32(cmbEmpleado.SelectedValue),
                    OrderDate = DateTime.Now
                };

                db.Orders.Add(pedido);
                db.SaveChanges();
                pedidoActualId = pedido.OrderId;
            }

            foreach (DataGridViewRow fila in dgvDetalle.Rows)
            {
                if (fila.Tag is not DetallePedidoTemporal detalleTemporal) continue;

                OrderDetail detalle = new OrderDetail
                {
                    OrderId = pedido.OrderId,
                    ProductId = detalleTemporal.ProductId,
                    UnitPrice = detalleTemporal.UnitPrice,
                    Quantity = Convert.ToInt16(detalleTemporal.Quantity),
                    Discount = Convert.ToSingle(detalleTemporal.Discount)
                };

                db.OrderDetails.Add(detalle);
            }

            db.SaveChanges();

            lblEstadoPedido.Text = $"Pedido cargado: #{pedido.OrderId}";
            txtPedidoId.Text = pedido.OrderId.ToString();
            btnGuardarPedido.Text = "Actualizar Pedido";
            CargarPedidosExistentes(pedido.OrderId);

            MessageBox.Show(pedidoActualId.HasValue ? "Pedido guardado/actualizado correctamente." : "Pedido guardado correctamente.");
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un producto de la tabla para quitarlo.");
                return;
            }

            DataGridViewRow fila = dgvDetalle.SelectedRows[0];
            if (fila.Tag is DetallePedidoTemporal detalle)
            {
                decimal sub = detalle.UnitPrice * detalle.Quantity;
                decimal desc = sub * detalle.Discount;
                subtotal -= sub;
                descuentoTotal -= desc;
                total -= (sub - desc);
            }

            dgvDetalle.Rows.Remove(fila);
            MostrarTotales();
        }

        private void ReiniciarTotales(bool limpiarDescuento)
        {
            subtotal = 0;
            descuentoTotal = 0;
            total = 0;
            MostrarTotales();

            if (limpiarDescuento)
                txtDescuento.Text = "0";
        }

        private void MostrarTotales()
        {
            lblSubtotal.Text = subtotal.ToString("C");
            lblDescuento.Text = descuentoTotal.ToString("C");
            lblTotal.Text = total.ToString("C");
        }

        private class DetallePedidoTemporal
        {
            public int ProductId { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public decimal Discount { get; set; }
        }
    }
}
=======

            var repository = new SupplierRepository();
            _supplierServices = new SupplierServices(repository);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuscarPorPais("USA");
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPais.Text))
            {
                MessageBox.Show("Por favor, escribe un país para realizar la filtración.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BuscarPorPais(txtPais.Text.Trim());
        }

        private void BuscarPorPais(string pais)
        {
            try
            {
                var proveedores = _supplierServices.FiltrarProveedoresPorPais(pais);
                dgvProveedores.DataSource = proveedores;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar la base de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpresa.Text))
            {
                MessageBox.Show("El nombre de la empresa es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var nuevo = new MiProveedor
            {
                CompanyName = txtEmpresa.Text.Trim(),
                ContactName = txtContacto.Text.Trim(),
                Country = txtPais.Text.Trim(),
                Phone = txtTelefono.Text.Trim()
            };

            string mensaje = _supplierServices.Registrar(nuevo);
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BuscarPorPais(txtPais.Text.Trim());
            LimpiarCamposFormulario();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Por favor, selecciona primero un proveedor de la tabla.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var modificado = new MiProveedor
            {
                SupplierID = int.Parse(txtId.Text),
                CompanyName = txtEmpresa.Text.Trim(),
                ContactName = txtContacto.Text.Trim(),
                Country = txtPais.Text.Trim(),
                Phone = txtTelefono.Text.Trim()
            };

            string mensaje = _supplierServices.Actualizar(modificado);
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            BuscarPorPais(txtPais.Text.Trim());
            LimpiarCamposFormulario();
        }

        private void DgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedores.Rows[e.RowIndex];

                txtId.Text = fila.Cells["SupplierID"].Value?.ToString() ?? "";
                txtEmpresa.Text = fila.Cells["CompanyName"].Value?.ToString() ?? "";
                txtContacto.Text = fila.Cells["ContactName"].Value?.ToString() ?? "";
                txtPais.Text = fila.Cells["Country"].Value?.ToString() ?? "";
                txtTelefono.Text = fila.Cells["Phone"].Value?.ToString() ?? "";
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposFormulario();
        }

        private void LimpiarCamposFormulario()
        {
            txtId.Clear();
            txtEmpresa.Clear();
            txtContacto.Clear();
            txtPais.Clear();
            txtTelefono.Clear();
        }
    }
}
>>>>>>> origin/GestionProveedores
