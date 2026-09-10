using System;
using System.Collections.Generic;

namespace EjercicioBD.Models;

public partial class Usuario
{
    public string NomUsuario { get; set; } = null!;

    public string? Password { get; set; }

    public virtual ICollection<Persona> Personas { get; set; } = new List<Persona>();
}
