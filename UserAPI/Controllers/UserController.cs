using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
       {
            "User1", "User2", "User3", "User4", "User5"
        };

        public IEnumerable<dynamic> Get()
        {
            return Summaries;
        }
    }
}
