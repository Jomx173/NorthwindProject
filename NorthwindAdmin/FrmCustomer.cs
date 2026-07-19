using Domain.Models.DTO;
using Domain.Services;

namespace NorthwindAdmin
{
    public partial class FrmCustomer : Form
    {
        private readonly CustomerService _customerService;
        private readonly ReportService _reportService;

        public FrmCustomer(CustomerService customerService, ReportService reportService)
        {
            InitializeComponent();
            _customerService = customerService;
            _reportService = reportService;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var customer = await _customerService.GetCustomerById("ALFKI");
            if (customer != null && customer.CustomerId == "ALFKI")
            {
                dataGridView1.DataSource = new List<Domain.Models.DTO.CustomerDto> { customer };
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {   

        }

        //private async void Form1_Load(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Entró al Load");

        //    var customer = await _customerService.GetCustomerById("ALFKI");

        //    if (customer == null)
        //    {
        //        MessageBox.Show("No encontró el cliente ALFKI");
        //        return;
        //    }

        //    dataGridView1.DataSource = new List<CustomerDto> { customer };
        //}
    }
}
