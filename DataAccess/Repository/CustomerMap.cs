using DataAccess.Models;
using Domain.Models.DTO;

namespace DataAccess.Repository
{
    internal class CustomerMap
    {
        public  static CustomerDto ToDto(Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.CustomerId,
                ContactName = customer.ContactName,
                ContactTitle = customer.ContactTitle,
                Phone = customer.Phone,
                City = customer.City
            };
        }
    }
}