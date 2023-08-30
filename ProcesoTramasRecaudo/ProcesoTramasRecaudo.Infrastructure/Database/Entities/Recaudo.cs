namespace ProcesoTramasRecaudo.Infrastructure.Database.Entities
{
    public class Recaudo
    {
        public Guid Id { get; set; }
        public Guid IdArchivo { get; set; }
        public string Cia { get; set; }
        public string CodProducto { get; set; }
        public string Producto { get; set; }
        public string NroCertificado { get; set; }
        public string NroSolicitud { get; set; }
        public string TipoDoc { get; set; }
        public string NroDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string TipoDocCont { get; set; }
        public string NroDocCont { get; set; }
        public string NombreCont { get; set; }
        public string ApellidosCont { get; set; }
        public int Cuota { get; set; }
        public string Condicion { get; set; }
        public DateTime FechaEmisionCuota { get; set; }
        public DateTime FechaPago { get; set; }
        public string Periodicidad { get; set; }
        public string MonedaId { get; set; }
        public string Moneda { get; set; }
        public decimal PrimaBruta { get; set; }
        public decimal PrimaNeta { get; set; }
        public string TipoComision { get; set; }
        public decimal PorcComiscomerc { get; set; }
        public decimal PorcComisrecaud { get; set; }
        public decimal IGV { get; set; }
        public decimal AbonoBanco { get; set; }
        public decimal AbonoCompania { get; set; }
    }
}
