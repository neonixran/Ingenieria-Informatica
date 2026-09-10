using System;
using System.Collections.Generic;

namespace pryCertamen3.Models;

public partial class Chofer
{
    public int IdChofer { get; set; }

    public string NomChofer { get; set; } = null!;

    public int IdEstado { get; set; }

    public virtual Estado IdEstadoNavigation { get; set; } = null!;

    public virtual ICollection<Salidum> Salida { get; set; } = new List<Salidum>();
}
