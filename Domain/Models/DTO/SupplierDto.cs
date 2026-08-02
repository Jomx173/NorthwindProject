namespace Domain.Models.DTO
{
    public class SupplierDto
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; } = string.Empty;
        public string? ContactName { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
    }
}
