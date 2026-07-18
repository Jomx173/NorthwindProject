using Domain.Models.DTO;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Extensions.DependencyInjection;

namespace NorthwindAdmin
{
    public partial class FrmSalesByCustomerReport : Form
    {
        private readonly ReportService _reportService;
        private readonly VentasEmpleadosServices _ventasEmpleadosServices;

        public FrmSalesByCustomerReport(ReportService reportService,
        VentasEmpleadosServices ventasEmpleadosServices)
        
        {
            InitializeComponent();

            _reportService = reportService;
            _ventasEmpleadosServices = ventasEmpleadosServices;

            StartPosition = FormStartPosition.CenterScreen;
        }

        private async Task CargarReporte()
        {
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date.AddDays(1).AddTicks(-1);

            var ventas = await _reportService.GetSalesByCustomer(desde, hasta);

            dataGridViewVentas.DataSource = ventas;
            CargarResumen(ventas);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CargarResumen(List<SalesByCustomerDto> ventas)
        {
            lblTotalVentas.Text = ventas.Sum(x => x.TotalVendido).ToString("C2");
            lblPedidosRealizados.Text = ventas.Sum(x => x.CantidadPedidos).ToString();

            var mejorCliente = ventas
                .OrderByDescending(x => x.TotalVendido)
                .FirstOrDefault();

            lblMejorCliente.Text = mejorCliente != null
                ? mejorCliente.CompanyName
                : "N/A";
        }

        private void ExportarDataGridViewACsv()
        {
            if (dataGridViewVentas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo CSV (*.csv)|*.csv";
            saveFileDialog.Title = "Guardar reporte";
            saveFileDialog.FileName = "Reporte_Ventas_Por_Cliente.csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < dataGridViewVentas.Columns.Count; i++)
                {
                    sb.Append(dataGridViewVentas.Columns[i].HeaderText);

                    if (i < dataGridViewVentas.Columns.Count - 1)
                        sb.Append(";");
                }

                sb.AppendLine();

                foreach (DataGridViewRow row in dataGridViewVentas.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dataGridViewVentas.Columns.Count; i++)
                        {
                            var valor = row.Cells[i].Value?.ToString() ?? "";
                            valor = valor.Replace(";", ",");

                            sb.Append(valor);

                            if (i < dataGridViewVentas.Columns.Count - 1)
                                sb.Append(";");
                        }

                        sb.AppendLine();
                    }
                }

                File.WriteAllText(saveFileDialog.FileName, sb.ToString(), Encoding.UTF8);

                MessageBox.Show("Reporte exportado correctamente.");
            }
        }

        private async void FrmSalesByCustomerReport_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(1996, 1, 1);
            dtpHasta.Value = new DateTime(1998, 12, 31);

            await CargarReporte();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarDataGridViewACsv();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(1996, 1, 1);
            dtpHasta.Value = new DateTime(1998, 12, 31);

            await CargarReporte();
        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmMenuGestiones frm =
            Program.ServiceProvider.GetRequiredService<FrmMenuGestiones>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
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
    }




}

