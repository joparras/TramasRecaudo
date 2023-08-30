using ProcesoTramasRecaudo.Domain.Enums;

namespace ProcesoTramasRecaudo.Infrastructure.Database.Entities
{
    public class Log
    {
        public Guid Id { get; set; }
        public Guid? ArchivoId { get; set; }
        public TipoDeLog TipoDeLog { get; set; }
        public string CasoDeUso { get; private set; }
        public string Mensaje { get; set; }
        public DateTime FechaDeLog { get; set; }
    }
}
