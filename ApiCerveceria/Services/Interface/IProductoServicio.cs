using ApiCerveceria.Models;

namespace ApiCerveceria.Services.Interface
{
    public partial interface  IProductoServicio
    {
        Task<Producto> GetProductosById(int id);
        Task<IEnumerable<Producto>> GetProductos();
    }
}
