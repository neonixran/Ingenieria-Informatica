using System;
using System.Collections.Generic;

namespace pryCertamen3.Models;

public partial class Estado
{
    public int IdEstado { get; set; }

    public string NomEstado { get; set; } = null!;

    public virtual ICollection<Camion> Camions { get; set; } = new List<Camion>();

    public virtual ICollection<Chofer> Chofers { get; set; } = new List<Chofer>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
