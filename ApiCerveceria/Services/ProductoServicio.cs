using ApiCerveceria.Data;
using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace ApiCerveceria.Services
{ 
    
    public partial class ProductoServicio : IProductoServicio
    {
        private readonly CerveceriaContext _cerveceriaContext;

        public ProductoServicio(CerveceriaContext cerveceriaContext)
        {
            this._cerveceriaContext = cerveceriaContext;
        }
        public async Task<IEnumerable<Producto>> GetProductos()
        {
            return await this._cerveceriaContext.Productos.ToListAsync();
        }

        public Task<Producto> GetProductosById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
