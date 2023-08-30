namespace ProcesoTramasRecaudo.Infrastructure.Database.Entities
{
    public class Archivo
    {
        public Guid Id { get; set; }
        public string NombreArchivo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Estado { get; set; }
        public int TipoArchivo { get; set; }
        public Guid? IdArchivo { get; set; }
        public List<Recaudo> Recaudos { get; set; }
        public List<Log> Logs { get; set; }
    }
}
