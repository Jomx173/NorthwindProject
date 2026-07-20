using Domain.Models.DTO;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using NortwindAdmin;

namespace NorthwindAdmin
{
    public partial class FrmClientes : Form
    {
        private readonly CustomerService _customerService;
        private readonly OrderService _orderService;

        public FrmClientes(
            CustomerService customerService,
            OrderService orderService)
        {
            InitializeComponent();

            _customerService = customerService;
            _orderService = orderService;

            dgvClientes.CellClick += dgvClientes_CellClick;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await CargarClientes();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCliente.Text.Trim().Length != 5)
                {
                    MessageBox.Show(
                        "El ID del cliente debe tener exactamente 5 caracteres.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var customer = new CustomerDto
                {
                    CustomerId = txtIdCliente.Text.Trim(),
                    CompanyName = txtEmpresa.Text.Trim(),
                    ContactName = txtContacto.Text.Trim(),
                    City = txtCiudad.Text.Trim()
                };

                await _customerService.AddCustomer(customer);

                MessageBox.Show(
                    "Cliente registrado correctamente",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await CargarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                string mensaje = ex.Message;

                if (ex.InnerException != null)
                {
                    mensaje += "\n\nDetalle:\n"
                               + ex.InnerException.Message;
                }

                MessageBox.Show(
                    mensaje,
                    "Error al registrar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new CustomerDto
                {
                    CustomerId = txtIdCliente.Text.Trim(),
                    CompanyName = txtEmpresa.Text.Trim(),
                    ContactName = txtContacto.Text.Trim(),
                    City = txtCiudad.Text.Trim()
                };

                await _customerService.UpdateCustomer(customer);

                MessageBox.Show(
                    "Cliente modificado correctamente",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await CargarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al modificar: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtIdCliente.Text.Trim();

                await _customerService.DeleteCustomer(id);

                MessageBox.Show(
                    "Cliente eliminado correctamente",
                    "Éxito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                await CargarClientes();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al eliminar: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txtCiudad.Text.Trim();

                if (string.IsNullOrWhiteSpace(texto))
                {
                    MessageBox.Show(
                        "Ingrese el nombre de la empresa, la ciudad o el país que desea buscar.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                var lista =
                    await _customerService.SearchCustomers(texto);

                dgvClientes.DataSource = lista;

                if (lista.Count == 0)
                {
                    MessageBox.Show(
                        "No se encontraron clientes.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al buscar: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            await CargarClientes();
        }

        private async Task CargarClientes()
        {
            try
            {
                var customers =
                    await _customerService.GetCustomers();

                dgvClientes.DataSource = customers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar clientes: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private async void dgvClientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    string customerId =
                        dgvClientes.Rows[e.RowIndex]
                        .Cells["CustomerId"]
                        .Value?.ToString() ?? "";

                    txtIdCliente.Text = customerId;

                    txtEmpresa.Text =
                        dgvClientes.Rows[e.RowIndex]
                        .Cells["CompanyName"]
                        .Value?.ToString() ?? "";

                    txtContacto.Text =
                        dgvClientes.Rows[e.RowIndex]
                        .Cells["ContactName"]
                        .Value?.ToString() ?? "";

                    txtCiudad.Text =
                        dgvClientes.Rows[e.RowIndex]
                        .Cells["City"]
                        .Value?.ToString() ?? "";

                    var pedidos =
                        await _orderService
                        .GetOrdersByCustomer(customerId);

                    dgvPedidos.DataSource = pedidos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar pedidos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            txtIdCliente.Clear();
            txtEmpresa.Clear();
            txtContacto.Clear();
            txtCiudad.Clear();
            txtIdCliente.Focus();
        }

        private void groupBoxBotones_Enter(
            object sender,
            EventArgs e)
        {
        }

        private void label9_Click(
            object sender,
            EventArgs e)
        {
        }

        private void groupBoxDatos_Enter(
            object sender,
            EventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FrmMenuPrincipal frm =
           Program.ServiceProvider.GetRequiredService<FrmMenuPrincipal>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmMenuGestiones frm =
          Program.ServiceProvider.GetRequiredService<FrmMenuGestiones>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmMenuReportes frm =
        Program.ServiceProvider.GetRequiredService<FrmMenuReportes>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmDashboard frm =
                   Program.ServiceProvider.GetRequiredService<FrmDashboard>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1 frm =
                   Program.ServiceProvider.GetRequiredService<Form1>();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
        "¿Está seguro de que desea cerrar el proyecto?",
        "Cerrar proyecto",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}