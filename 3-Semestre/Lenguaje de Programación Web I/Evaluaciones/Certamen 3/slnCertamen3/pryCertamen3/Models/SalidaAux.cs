using Microsoft.AspNetCore.Mvc;

namespace pryCertamen3.Models
{
    public class SalidaAux
    {
        public int id { get; set; }

        public DateOnly fecha { get; set; }

        public string? planta { get; set; }

        public string? codCamion { get; set; }

        public string? chofer { get; set; }

        public int idEstado { get; set; }
        public string? estado { get; set; }
        public string? usuario { get; set; }
        public string? respuesta { get; set; } // Corresponde al mensaje en caso de una excepción.
    }
}
