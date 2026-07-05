using Data_access.Models;
using Domain.Models.DTO;

namespace Data_access.Repository.CustomerRepository
{
    public class CustomerMap
    {
        public static CustomerDTO ToDto(Customer customer)
        {
            return new CustomerDTO
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