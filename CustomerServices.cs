using System;

namespace Domain.Services
{
	public CustomerServices
	{
		private readonly ICustomer _customer;

			public CustomerServive(ICustomer customer, string id)
			{

			_customer = customer;
			}

			public async Task<List<Customers>> GetCustomers()
			{
			return await _customer.GetCustomers();
		 
			public async Task<CustomersDTO> GetCustomersByid(string Customers)
			{
				return await _customer.GetCustomersByid(CustomersId);

    }
	}
}
