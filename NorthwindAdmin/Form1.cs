using DataAccces.Context;
using DataAccces.Models;

namespace NorthwindAdmin
{
    public partial class Form1 : Form
    {
        private readonly NorthwindContext db = new NorthwindContext();

        private DataGridView dgvPedidos = new DataGridView();
        private Label lblPedidosExistentes = new Label();
        private Button btnMostrarPedidos = new Button();
        private Panel panelIzquierdo = new Panel();

        private int? pedidoActualId = null;
        private decimal subtotal = 0;
        private decimal descuentoTotal = 0;
        private decimal total = 0;

        public Form1()
        {
            InitializeComponent();
            ConfigurarSeccionPedidosExistentes();
            CargarDatos();
            AplicarDisenoInstitucional();
        }

        private void AplicarDisenoInstitucional()
        {
            // Estándar visual solicitado
            Color fondoFormulario = Color.FromArgb(240, 240, 240);   // #F0F0F0
            Color azulPanel = Color.FromArgb(25, 25, 111);           // #19196F
            Color azulEncabezado = Color.FromArgb(25, 25, 111);      // #19196F
            Color azulAcento = Color.FromArgb(0, 120, 215);          // azul para columna destacada
            Color textoTabla = Color.FromArgb(47, 79, 79);           // #2F4F4F
            Color grisGrid = Color.FromArgb(221, 221, 221);          // #DDDDDD
            Color filaAlterna = Color.FromArgb(245, 245, 245);       // #F5F5F5

            BackColor = fondoFormulario;
            ClientSize = new Size(1520, 790);

            // Panel azul izquierdo para futuros atajos del sistema
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.BackColor = azulPanel;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Size = new Size(155, ClientSize.Height);
            panelIzquierdo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;

            if (!Controls.Contains(panelIzquierdo))
            {
                Controls.Add(panelIzquierdo);
                panelIzquierdo.SendToBack();
            }

            // Mover el contenido hacia la derecha para respetar el panel azul
            foreach (Control control in Controls)
            {
                if (control == panelIzquierdo) continue;
                if (control.Left < 170)
                    control.Left += 120;
            }

            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.Location = new Point(180, 20);
            lblTitulo.Text = "Gestión de Pedidos";

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

            // Ubicación final tipo referencia: panel izquierdo, controles arriba y tablas al centro
            lblPedidoId.Location = new Point(205, 84);
            txtPedidoId.Location = new Point(305, 81);
            btnBuscarPedido.Location = new Point(500, 75);
            btnNuevoPedido.Location = new Point(650, 75);
            lblEstadoPedido.Location = new Point(825, 84);

            lblCliente.Location = new Point(225, 139);
            cmbCliente.Location = new Point(305, 136);
            lblEmpleado.Location = new Point(655, 139);
            cmbEmpleado.Location = new Point(760, 136);

            lblProducto.Location = new Point(210, 196);
            cmbProducto.Location = new Point(305, 193);
            lblCantidadTexto.Location = new Point(665, 196);
            txtCantidad.Location = new Point(760, 193);
            lblDescuentoTexto.Location = new Point(880, 196);
            txtDescuento.Location = new Point(1005, 193);
            btnAgregarProducto.Location = new Point(1115, 181);
            btnQuitarProducto.Location = new Point(1295, 181);

            lblPedidosExistentes.Location = new Point(180, 245);
            btnMostrarPedidos.Location = new Point(1250, 238);
            dgvPedidos.Location = new Point(180, 280);
            dgvPedidos.Size = new Size(1210, 170);

            dgvDetalle.Location = new Point(180, 500);
            dgvDetalle.Size = new Size(1210, 170);

            lblSubtotalTexto.Location = new Point(880, 685);
            lblSubtotal.Location = new Point(1000, 685);
            lblDescuentoTotalTexto.Location = new Point(850, 715);
            lblDescuento.Location = new Point(1000, 715);
            lblTotalTexto.Location = new Point(895, 745);
            lblTotal.Location = new Point(1000, 745);
            btnGuardarPedido.Location = new Point(1180, 700);
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
