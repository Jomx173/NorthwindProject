namespace Domain.Models.DTO
{
    public class CustomerDto
    {
        // ID del cliente
        public string CustomerID { get; set; }

        // Nombre de la empresa
        public string CompanyName { get; set; }

        // Nombre del contacto
        public string ContactName { get; set; }

        // Ciudad
        public string City { get; set; }

        // (Opcional) Teléfono
        public string Phone { get; set; }

        // (Opcional) Cargo del contacto
        public string ContactTitle { get; set; }
    }
}
