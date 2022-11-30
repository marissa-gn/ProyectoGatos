namespace ApiCerveceria.Models
{
    public class Vendedor
    {
        public Vendedor()
        {
            Ventas= new HashSet<Ventas>();
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public ICollection<Ventas> Ventas{ get; set; }
    }
}
