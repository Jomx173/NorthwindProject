
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.DTO
{
    public class CustomerDto
    {
        public string CustomerId { get; set; } = string.Empty;

        public string CompanyName { get; set; } = string.Empty;

        public string ContactName { get; set; } = string.Empty;

        public string ContactTitle { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;
    }
}