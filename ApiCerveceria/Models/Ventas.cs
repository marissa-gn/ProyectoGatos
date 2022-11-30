namespace ApiCerveceria.Models
{
    public class Ventas
    {
        public int Id{ get; set; }
        public int NumeroVenta { get; set; }
        public int IdProducto { get; set; }
        public int IdVendedor { get; set; }
        public int Cantidad { get; set; }
        public decimal Total { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Vendedor Vendedor{ get; set; }
    }
}
