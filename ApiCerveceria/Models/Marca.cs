namespace ApiCerveceria.Models
{
    public class Marca
    {
        public Marca()
        {
            Productos = new HashSet<Producto>();
        }
        public int MarcaId { get; set; }
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }
    }
}
