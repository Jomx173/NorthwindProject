using Domain.Models.DTO;
using Domain.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ReportService : IReport
    {
        private readonly IReport _report;

        public ReportService(IReport report)
        {
            _report = report;
        }

        public async Task<List<SalesByCustomerDto>> GetSalesByCustomer(DateTime desde, DateTime hasta)
        {
            return await _report.GetSalesByCustomer(desde, hasta);
        }
    }
}
