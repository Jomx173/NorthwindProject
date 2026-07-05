using System;
using System.Collections.Generic;

namespace Data_access.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
