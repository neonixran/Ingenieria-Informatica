using System;
using System.Collections.Generic;

namespace pryCertamen3.Models;

public partial class Plantum
{
    public int IdPlanta { get; set; }

    public string NomPlanta { get; set; } = null!;

    public virtual ICollection<Camion> Camions { get; set; } = new List<Camion>();

    public virtual ICollection<Salidum> Salida { get; set; } = new List<Salidum>();
}
