using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IPubicProductService _pubicProductService;
        public ProductController(IPubicProductService pubicProductService)
        {
            _pubicProductService = pubicProductService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var product = await _pubicProductService.GetAll();
            return Ok(product);
        }
    }
}
