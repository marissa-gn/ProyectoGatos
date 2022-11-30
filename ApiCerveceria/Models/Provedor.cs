namespace ApiCerveceria.Models
{

    public class Provedor
    {
        public Provedor()
        {
            Productos=new HashSet<Producto>();
        }
        public int Id{ get; set; }
        public string Nombre { get; set; }
        public ICollection<Producto> Productos { get; set; }

        
    }
}
