using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwTotalOrdenesSinDescuento
{
    public int OrderId { get; set; }

    public decimal? Total { get; set; }
}
