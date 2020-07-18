using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MarketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [Route("GetProductList")]
        public IActionResult GetProductList()
        {
            return Ok(new List<string> { "Leptop", "Phone", "Pen" });
        }
    }
}
