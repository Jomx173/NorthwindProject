using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models.Interfaces
{
	public interface Icustomers()
	{
		Task<List<Customers>> GetCustomers();

		Task<CustomersDTO>GetCustomersByid(string Customers)
	}
}
