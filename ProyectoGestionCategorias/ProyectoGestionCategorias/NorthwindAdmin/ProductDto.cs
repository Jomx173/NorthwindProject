using System;

namespace NorthwindAdmin
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal? Precio { get; set; }
        public short? Stock { get; set; }
    }
}