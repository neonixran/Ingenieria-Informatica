using System;
using System.Collections.Generic;

namespace pryCertamen3.Models;

public partial class Salidum
{
    public int IdSalida { get; set; }

    public DateOnly FechaSalida { get; set; }

    public int IdPlanta { get; set; }

    public string CodCamion { get; set; } = null!;

    public int IdChofer { get; set; }

    public int IdEstadoSalida { get; set; }

    public string Usuario { get; set; } = null!;

    public virtual Camion CodCamionNavigation { get; set; } = null!;

    public virtual Chofer IdChoferNavigation { get; set; } = null!;

    public virtual EstadoSalidum IdEstadoSalidaNavigation { get; set; } = null!;

    public virtual Plantum IdPlantaNavigation { get; set; } = null!;

    public virtual Usuario UsuarioNavigation { get; set; } = null!;
}
