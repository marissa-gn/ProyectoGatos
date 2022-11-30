namespace ApiCerveceria.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre  { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public string Imagen { get; set; }
        public int Cantidad { get; set; }
        public int MarcaId { get; set; }
        public int TipoId { get; set; }

        public virtual Marca Marca { get; set; }
        public virtual Tipo Tipo { get; set; }


    }
}
