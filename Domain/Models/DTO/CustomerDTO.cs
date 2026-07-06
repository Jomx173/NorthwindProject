using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.DTO
{
    public class CustomerDto
    {
        public String Id { get; set; }
        public String ContactName { get; set; }
        public String ContactTile { get; set; }
        public String Phone { get; set; }
        public String City { get; set; }
    }
}
