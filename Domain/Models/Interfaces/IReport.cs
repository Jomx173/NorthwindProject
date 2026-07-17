using Domain.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Interfaces
{
    public interface IReport
    {
        Task<List<SalesByCustomerDto>> GetSalesByCustomer(DateTime desde, DateTime hasta);
    }
}
