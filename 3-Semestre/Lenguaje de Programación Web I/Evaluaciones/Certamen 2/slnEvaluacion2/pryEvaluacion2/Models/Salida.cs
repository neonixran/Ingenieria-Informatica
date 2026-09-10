namespace pryEvaluacion2.Models
{
    public class Salida
    {
        public int id { get; set; }
        public string? patenteCamion { get; set; } // FK desde Camion
        public string? nombreConductor { get; set; } // FK desde Conductor
        public int idConductor { get; set; }
        public string? tipoCarga { get; set; }
        public string? fechaHora { get; set; }
        public string? estado { get; set; }
    }
}
