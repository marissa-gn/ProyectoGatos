using ApiCerveceria.Models;
using ApiCerveceria.Services.Interface;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
        // GET: api/<ProductoController>
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

        // POST api/<ProductoController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
