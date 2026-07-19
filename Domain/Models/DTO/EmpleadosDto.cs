using System;

namespace Domain.Models.DTO
{
    public class EmpleadosDto
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Title { get; set; }

        public string City { get; set; }

        public string Phone { get; set; }

        // Agregados
        public string Country { get; set; }

        public string Address { get; set; }
    }
}