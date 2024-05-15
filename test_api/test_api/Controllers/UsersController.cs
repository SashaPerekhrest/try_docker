using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace test_api.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new[]
            {
                new {Name = "Sasha"},
                new {Name = "Vachic" }
            };

            return Ok(users);
        }
    }
}
