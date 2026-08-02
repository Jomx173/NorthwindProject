using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using NortwindAdmin;
using System.Text;

namespace NorthwindAdmin
{
    public partial class FrmVentasEmpleados : Form
    {
        private readonly ReportService _reportService;
        private readonly VentasEmpleadosServices _ventasEmpleadosServices;

        public FrmVentasEmpleados(VentasEmpleadosServices ventasEmpleadosServices)
        {
            InitializeComponent();

            dtpDesde.Format = DateTimePickerFormat.Custom;
            dtpDesde.CustomFormat = "dddd dd 'de' MMMM 'de' yyyy";

            dtpHasta.Format = DateTimePickerFormat.Custom;
            dtpHasta.CustomFormat = "dddd dd 'de' MMMM 'de' yyyy";

            _ventasEmpleadosServices = ventasEmpleadosServices;
        }

        private async void FrmVentasEmpleados_Load(object sender, EventArgs e)
        {

            dtpDesde.Value = new DateTime(1996, 1, 1);
            dtpHasta.Value = new DateTime(1998, 12, 31);

            ConfigurarTabla();

            await CargarReporte();
        }

        private async Task CargarReporte()
        {
            try
            {
                if (dtpDesde.Value.Date > dtpHasta.Value.Date)
                {
                    MessageBox.Show(
                        "La fecha inicial no puede ser mayor que la fecha final.",
                        "Fechas incorrectas",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                var reporte = await _ventasEmpleadosServices.GetVentasEmpleados(
                 dtpDesde.Value.Date,
                 dtpHasta.Value.Date
                  );



                dgvVentasEmpleados.DataSource = reporte;

                DarFormatoColumnas();
                CalcularResumen();

                if (reporte.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron ventas para mostrar.",
                        "Sin datos",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un error al cargar el reporte:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void ConfigurarTabla()
        {
            dgvVentasEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentasEmpleados.ReadOnly = true;
            dgvVentasEmpleados.AllowUserToAddRows = false;
            dgvVentasEmpleados.AllowUserToDeleteRows = false;
            dgvVentasEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVentasEmpleados.MultiSelect = false;
            dgvVentasEmpleados.RowHeadersVisible = false;

            dgvVentasEmpleados.BackgroundColor = Color.White;
            dgvVentasEmpleados.BorderStyle = BorderStyle.None;
            dgvVentasEmpleados.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVentasEmpleados.GridColor = Color.Gainsboro;

            dgvVentasEmpleados.EnableHeadersVisualStyles = false;
            dgvVentasEmpleados.ColumnHeadersHeight = 40;

            dgvVentasEmpleados.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgvVentasEmpleados.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvVentasEmpleados.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvVentasEmpleados.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvVentasEmpleados.DefaultCellStyle.BackColor = Color.White;
            dgvVentasEmpleados.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dgvVentasEmpleados.DefaultCellStyle.SelectionBackColor = Color.Honeydew;
            dgvVentasEmpleados.DefaultCellStyle.SelectionForeColor = Color.DarkGreen;
            dgvVentasEmpleados.DefaultCellStyle.Font = new Font("Segoe UI", 10);

            dgvVentasEmpleados.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvVentasEmpleados.RowTemplate.Height = 35;
        }

        private void DarFormatoColumnas()
        {
            if (dgvVentasEmpleados.Columns["Ranking"] != null)
            {
                dgvVentasEmpleados.Columns["Ranking"].HeaderText = "Ranking";
                dgvVentasEmpleados.Columns["Ranking"].DisplayIndex = 0;
            }

            if (dgvVentasEmpleados.Columns["EmployeeID"] != null)
            {
                dgvVentasEmpleados.Columns["EmployeeID"].HeaderText = "ID Empleado";
                dgvVentasEmpleados.Columns["EmployeeID"].DisplayIndex = 1;
            }

            if (dgvVentasEmpleados.Columns["Empleado"] != null)
            {
                dgvVentasEmpleados.Columns["Empleado"].HeaderText = "Empleado";
                dgvVentasEmpleados.Columns["Empleado"].DisplayIndex = 2;
            }

            if (dgvVentasEmpleados.Columns["PedidosAtendidos"] != null)
            {
                dgvVentasEmpleados.Columns["PedidosAtendidos"].HeaderText = "Pedidos Atendidos";
                dgvVentasEmpleados.Columns["PedidosAtendidos"].DisplayIndex = 3;
            }

            if (dgvVentasEmpleados.Columns["VentasRealizadas"] != null)
            {
                dgvVentasEmpleados.Columns["VentasRealizadas"].HeaderText = "Ventas Realizadas";
                dgvVentasEmpleados.Columns["VentasRealizadas"].DefaultCellStyle.Format = "N2";
                dgvVentasEmpleados.Columns["VentasRealizadas"].DisplayIndex = 4;
            }
        }

        private void CalcularResumen()
        {
            decimal totalVentas = 0;
            int totalPedidos = 0;
            string mejorVendedor = "-";
            decimal mayorVenta = 0;

            bool hayDatos = false;

            foreach (DataGridViewRow fila in dgvVentasEmpleados.Rows)
            {
                if (fila.IsNewRow)
                {
                    continue;
                }

                hayDatos = true;

                decimal ventasEmpleado = 0;
                int pedidosEmpleado = 0;

                if (fila.Cells["VentasRealizadas"].Value != null)
                {
                    decimal.TryParse(fila.Cells["VentasRealizadas"].Value.ToString(), out ventasEmpleado);
                    totalVentas += ventasEmpleado;
                }

                if (fila.Cells["PedidosAtendidos"].Value != null)
                {
                    int.TryParse(fila.Cells["PedidosAtendidos"].Value.ToString(), out pedidosEmpleado);
                    totalPedidos += pedidosEmpleado;
                }

                if (ventasEmpleado > mayorVenta)
                {
                    mayorVenta = ventasEmpleado;

                    if (fila.Cells["Empleado"].Value != null)
                    {
                        mejorVendedor = fila.Cells["Empleado"].Value.ToString();
                    }
                }
            }

            if (!hayDatos)
            {
                lblResultadoVentas.Text = "L. 0.00";
                lblResultadoPedidos.Text = "-";
                lblResultadoMejorV.Text = "-";
                return;
            }

            lblResultadoVentas.Text = "L. " + totalVentas.ToString("N2");
            lblResultadoPedidos.Text = totalPedidos > 0 ? totalPedidos.ToString() : "-";
            lblResultadoMejorV.Text = !string.IsNullOrWhiteSpace(mejorVendedor) ? mejorVendedor : "-";
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await CargarReporte();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvVentasEmpleados.DataSource = null;

            lblResultadoVentas.Text = "L. 0.00";
            lblResultadoPedidos.Text = "0";
            lblResultadoMejorV.Text = "Sin datos";
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewACsv();
        }

        private void ExportarDataGridViewACsv()
        {
            if (dgvVentasEmpleados.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar reporte";
            saveFileDialog.FileName = "Reporte_Ventas_Por_Empleado.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < dgvVentasEmpleados.Columns.Count; i++)
                {
                    sb.Append(dgvVentasEmpleados.Columns[i].HeaderText);

                    if (i < dgvVentasEmpleados.Columns.Count - 1)
                        sb.Append(";");
                }

                sb.AppendLine();

                foreach (DataGridViewRow row in dgvVentasEmpleados.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dgvVentasEmpleados.Columns.Count; i++)
                        {
                            var valor = row.Cells[i].Value?.ToString() ?? "";
                            valor = valor.Replace(";", ",");

                            sb.Append(valor);

                            if (i < dgvVentasEmpleados.Columns.Count - 1)
                                sb.Append(";");
                        }

                        sb.AppendLine();
                    }
                }

                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Reporte exportado correctamente.");
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblResultadoMejorV_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMenuReportes frm = new FrmMenuReportes(
            _reportService, _ventasEmpleadosServices);

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmMenuGestiones frm =
            Program.ServiceProvider.GetRequiredService<FrmMenuGestiones>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm =
            Program.ServiceProvider.GetRequiredService<FrmMenuPrincipal>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
            "¿Desea salir del sistema?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmInventario frm =
            Program.ServiceProvider.GetRequiredService<FrmInventario>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDashboard frm =
            Program.ServiceProvider.GetRequiredService<FrmDashboard>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }
    }


}
