namespace apiComercio.Models
{
    public class Articulo
    {
        public int ArticuloId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public decimal Precio { get; set; }
        public decimal PrecioOferta { get; set; }
    }
}
