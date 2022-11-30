namespace ApiCerveceria.Models
{
    public class Tipo
    { 
        public Tipo()
        {
            Productos = new HashSet<Producto>();
        }
        public int TipoId { get; set; }
        public string Nombre { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}
