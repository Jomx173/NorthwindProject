using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class VwClientesXempleado
{
    public string Empleado { get; set; } = null!;

    public int? Clientes { get; set; }
}
