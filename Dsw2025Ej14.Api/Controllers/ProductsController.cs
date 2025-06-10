using Dsw2025Ej14.Api.Data;
using Microsoft.AspNetCore.Mvc;

namespace Dsw2025Ej14.Api.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController: ControllerBase
    {
        public IPersistencia _persistencia;
        public ProductsController(IPersistencia persistencia) {

            _persistencia = persistencia;
        }
        [HttpGet()]

        public IActionResult GetProducts() {
            return Ok(_persistencia.GetProducts());
            
        }

        [HttpGet("{sku}")]

        public IActionResult GetProduct(string sku) { 
            var product = _persistencia.GetProduct(sku);

            return Ok(_persistencia.GetProduct(sku));
        }
    }
}
