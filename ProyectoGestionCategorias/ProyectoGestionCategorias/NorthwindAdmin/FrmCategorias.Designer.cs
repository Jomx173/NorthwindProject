using System.Windows.Forms;
using System.Drawing;

namespace NorthwindAdmin
{
    partial class FrmCategorias
    {
        private System.ComponentModel.IContainer components = null;

        private Panel panelSidebar;
        private Panel panelContenido;
        private ImageList imageListMenu;
        private Label lblSidebarTitle;
        private Label lblMainTitle;
        private Label lblSubtitle;

        private DataGridView dgvCategorias;
        private DataGridView dgvProductos;
        private Label lblTituloProductos;

        private TextBox txtId;
        private TextBox txtNombre;
        private TextBox txtDescription;

        private Label lblId;
        private Label lblNombre;
        private Label lblDescripcion;

        private Button btnBuscar;
        private Button btnLimpiar;
        private Button btnRegistrar;
        private Button btnActualizar;
        private Button btnEliminar;

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

            // Configuración Ventana Principal
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 850);
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Módulo de Administración - Gestión de Categorías y Productos";

            // Panel Lateral
            this.panelSidebar = new Panel();
            this.panelSidebar.Width = 240;
            this.panelSidebar.Dock = DockStyle.Left;
            this.panelSidebar.BackColor = Color.FromArgb(17, 29, 122);
            this.Controls.Add(this.panelSidebar);

            this.lblSidebarTitle = new Label();
            this.lblSidebarTitle.Text = "IMPLEMENTACIÓN\nDE SISTEMAS\nDE SOFTWARE\n\nNORTHWIND";
            this.lblSidebarTitle.Font = new Font("Segoe UI", 11, FontStyle.Bold | FontStyle.Italic);
            this.lblSidebarTitle.ForeColor = Color.White;
            this.lblSidebarTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblSidebarTitle.Dock = DockStyle.Top;
            this.lblSidebarTitle.Height = 160;
            this.panelSidebar.Controls.Add(this.lblSidebarTitle);

            // Menu e Iconos
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
                try
                {
                    this.imageListMenu.Images.Add("inicio", Image.FromFile("../../../Resources/ico_inicio.png"));
                    this.imageListMenu.Images.Add("gestiones", Image.FromFile("../../../Resources/ico_gestiones.png"));
                    this.imageListMenu.Images.Add("controles", Image.FromFile("../../../Resources/ico_controles.png"));
                    this.imageListMenu.Images.Add("reportes", Image.FromFile("../../../Resources/ico_reportes.png"));
                    this.imageListMenu.Images.Add("dashboard", Image.FromFile("../../../Resources/ico_dashboard.png"));
                    this.imageListMenu.Images.Add("cerrar", Image.FromFile("../../../Resources/ico_cerrar.png"));
                }
                catch { /* Salvaguarda */ }
            }

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
                btnMenu.Padding = new Padding(12, 0, 0, 0);

                this.panelSidebar.Controls.Add(btnMenu);
                startButtonY += 55;
            }

            // Panel Contenido
            this.panelContenido = new Panel();
            this.panelContenido.Dock = DockStyle.Fill;
            this.panelContenido.BackColor = Color.FromArgb(244, 245, 247);
            this.Controls.Add(this.panelContenido);
            this.panelContenido.BringToFront();

            this.lblMainTitle = new Label();
            this.lblMainTitle.Text = "Gestión de Categorías";
            this.lblMainTitle.Font = new Font("Segoe UI", 22, FontStyle.Bold);
            this.lblMainTitle.Location = new Point(30, 20);
            this.lblMainTitle.AutoSize = true;
            this.panelContenido.Controls.Add(this.lblMainTitle);

            this.lblSubtitle = new Label();
            this.lblSubtitle.Text = "Administración del catálogo de categorías y visualización interactiva de productos asociados.";
            this.lblSubtitle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            this.lblSubtitle.ForeColor = Color.Gray;
            this.lblSubtitle.Location = new Point(35, 65);
            this.lblSubtitle.AutoSize = true;
            this.panelContenido.Controls.Add(this.lblSubtitle);

            int topRow = 115;

            this.lblId = new Label { Text = "ID Categoría", Location = new Point(30, topRow), AutoSize = true, Font = new Font("Segoe UI", 9) };
            this.txtId = new TextBox { Location = new Point(30, topRow + 22), Width = 100, Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle, ReadOnly = true, BackColor = Color.FromArgb(225, 228, 233) };

            this.lblNombre = new Label { Text = "Nombre de Categoría *", Location = new Point(150, topRow), AutoSize = true, Font = new Font("Segoe UI", 9) };
            this.txtNombre = new TextBox { Location = new Point(150, topRow + 22), Width = 250, Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle };

            this.lblDescripcion = new Label { Text = "Descripción", Location = new Point(420, topRow), AutoSize = true, Font = new Font("Segoe UI", 9) };
            this.txtDescription = new TextBox { Location = new Point(420, topRow + 22), Width = 450, Font = new Font("Segoe UI", 10), BorderStyle = BorderStyle.FixedSingle };

            this.panelContenido.Controls.AddRange(new Control[] { lblId, txtId, lblNombre, txtNombre, lblDescripcion, txtDescription });

            // Botones
            int btnRow = topRow + 65;

            this.btnBuscar = new Button { Text = "Refrescar", Location = new Point(30, btnRow), Width = 120, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = Color.White, ForeColor = Color.Black, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            this.btnBuscar.FlatAppearance.BorderColor = Color.LightGray;

            this.btnLimpiar = new Button { Text = "Limpiar", Location = new Point(160, btnRow), Width = 110, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = Color.White, ForeColor = Color.Black, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            this.btnLimpiar.FlatAppearance.BorderColor = Color.LightGray;

            this.btnRegistrar = new Button { Text = "Guardar Nueva", Location = new Point(280, btnRow), Width = 160, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(40, 167, 69), ForeColor = Color.White, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            this.btnRegistrar.FlatAppearance.BorderSize = 0;

            this.btnActualizar = new Button { Text = "Modificar Selección", Location = new Point(450, btnRow), Width = 170, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(0, 123, 255), ForeColor = Color.White, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            this.btnActualizar.FlatAppearance.BorderSize = 0;

            this.btnEliminar = new Button { Text = "Eliminar Categoría", Location = new Point(630, btnRow), Width = 160, Height = 35, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(220, 53, 69), ForeColor = Color.White, Font = new Font("Segoe UI", 9, FontStyle.Bold) };
            this.btnEliminar.FlatAppearance.BorderSize = 0;

            this.panelContenido.Controls.AddRange(new Control[] { btnBuscar, btnLimpiar, btnRegistrar, btnActualizar, btnEliminar });

            // Grillas
            this.dgvCategorias = new DataGridView();
            this.dgvCategorias.Location = new Point(30, btnRow + 60);
            this.dgvCategorias.Size = new Size(530, 480);
            this.dgvCategorias.BackgroundColor = Color.White;
            this.dgvCategorias.BorderStyle = BorderStyle.None;
            this.dgvCategorias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCategorias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvCategorias.EnableHeadersVisualStyles = false;
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(235, 237, 240);
            this.dgvCategorias.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.dgvCategorias.ColumnHeadersHeight = 38;
            this.dgvCategorias.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            this.dgvCategorias.DefaultCellStyle.SelectionBackColor = Color.FromArgb(210, 225, 250);
            this.dgvCategorias.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvCategorias.RowTemplate.Height = 33;
            this.dgvCategorias.AllowUserToAddRows = false;
            this.dgvCategorias.ReadOnly = true;
            this.dgvCategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorias.MultiSelect = false;

            this.lblTituloProductos = new Label { Text = "Productos pertenecientes a la categoría seleccionada:", Location = new Point(590, btnRow + 38), AutoSize = true, Font = new Font("Segoe UI", 10, FontStyle.Bold), ForeColor = Color.FromArgb(50, 50, 50) };

            this.dgvProductos = new DataGridView();
            this.dgvProductos.Location = new Point(590, btnRow + 60);
            this.dgvProductos.Size = new Size(580, 480);
            this.dgvProductos.BackgroundColor = Color.White;
            this.dgvProductos.BorderStyle = BorderStyle.None;
            this.dgvProductos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(225, 230, 240);
            this.dgvProductos.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            this.dgvProductos.ColumnHeadersHeight = 38;
            this.dgvProductos.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            this.dgvProductos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 235, 210);
            this.dgvProductos.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dgvProductos.RowTemplate.Height = 33;
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.panelContenido.Controls.AddRange(new Control[] { dgvCategorias, lblTituloProductos, dgvProductos });

            // Enlace de Eventos Sincronizados
            this.Load += new System.EventHandler(this.FrmCategorias_Load);
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            this.btnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            this.dgvCategorias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellClick);

            this.ResumeLayout(false);
        }

        #endregion
    }
}