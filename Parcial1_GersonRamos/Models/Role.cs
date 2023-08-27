﻿using System;
using System.Collections.Generic;

namespace Parcial1_GersonRamos.Models;

public partial class Role
{
    public int IdRol { get; set; }

    public string? RoleName { get; set; }

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
