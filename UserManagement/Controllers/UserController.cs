using Microsoft.AspNetCore.Mvc;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = new List<object>();

            for (int i = 1; i <= 150; i++)
            {
                users.Add(new
                {
                    id = i,
                    name = "User " + i,
                    email = "user" + i + "@gmail.com",
                    phone = "090000" + i.ToString("000"),
                    @class = "Class " + (i % 5 + 1)
                });
            }

            return Ok(new { data = users });
        }
    }
}