using System;
using System.Collections.Generic;

namespace pryDecimas.Models;

public partial class Nota
{
    public int IdNota { get; set; }

    public decimal? Nota1 { get; set; }

    public int? NNota { get; set; }

    public int CodAlumno { get; set; }

    public int IdAsignatura { get; set; }
}
