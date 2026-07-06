using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class DwEmpleado
{
    public int CodigoEmpleado { get; set; }

    public string NombreCompleto { get; set; } = null!;

    public int EdadActual { get; set; }

    public string? Direccion { get; set; }
}
