using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.AspNetCore.Mvc;


namespace ApiCerveceria.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        private readonly IProductoServicio _productoServicio;
        public ProductoController(IProductoServicio productoServicio)
        {
            this._productoServicio = productoServicio;
        }
   
        [HttpGet]
        public async Task<IEnumerable<Producto>> Get()
        {
            return await this._productoServicio.GetProductos();
        }

        // GET api/<ProductoController>/5
        [HttpGet("{id}")]
        public async Task<Producto> Get(int id)
        {
            return await this._productoServicio.GetProductosById(id);
        }

       
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

     
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
