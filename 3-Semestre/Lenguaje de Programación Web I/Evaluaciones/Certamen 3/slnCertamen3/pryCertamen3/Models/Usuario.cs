using System;
using System.Collections.Generic;

namespace pryCertamen3.Models;

public partial class Usuario
{
    public string Usuario1 { get; set; } = null!;

    public string NomPersona { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int IdEstado { get; set; }

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual ICollection<Salidum> Salida { get; set; } = new List<Salidum>();
}
