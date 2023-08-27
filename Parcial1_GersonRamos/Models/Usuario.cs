using System;
using System.Collections.Generic;

namespace Parcial1_GersonRamos.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string? Usuario1 { get; set; }

    public string? Clave { get; set; }

    public int? IdRol { get; set; }

    public virtual Role? IdRolNavigation { get; set; }
}
