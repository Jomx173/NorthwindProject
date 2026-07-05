using Domain.Services;

namespace NorthwinAdmin
{
    public partial class Form1 : Form
    {

        private readonly CustomerServices _customerServices;
        public Form1(CustomerServices customerServices)
        {
            InitializeComponent();
            _customerServices = customerServices;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var customer = await _customerServices.GetCustomersById("ALFKI");
            if (customer != null && customer.Id == "ALFKI")
            {

                dataGridView1.DataSource = new List<Domain.Models.DTO.CustomerDTO> { customer };
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
