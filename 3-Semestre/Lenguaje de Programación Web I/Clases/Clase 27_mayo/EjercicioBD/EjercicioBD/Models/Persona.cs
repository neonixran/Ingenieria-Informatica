using System;
using System.Collections.Generic;

namespace EjercicioBD.Models;

public partial class Persona
{
    public int Rut { get; set; }

    public string Dv { get; set; } = null!;

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string NomUsuario { get; set; } = null!;

    public virtual Usuario NomUsuarioNavigation { get; set; } = null!;
}
