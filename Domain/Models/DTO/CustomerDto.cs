using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.DTO
{
    public class CustomerDto
    {
        public string Id { get; set; }

        public string ContactName { get; set; }

        public string ContactTitle { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }
    }
}
