using System.Windows.Forms;
using System.Drawing;

namespace NorthwindAdmin
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

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