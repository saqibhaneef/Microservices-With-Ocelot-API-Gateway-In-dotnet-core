using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Product1", "Product2", "ChillProduct3", "Product4", "Product5"
        };

        public IEnumerable<dynamic> Get()
        {
            return Summaries;
        }
    }
}
