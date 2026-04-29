using Microsoft.AspNetCore.Mvc;
using UserManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var data = await _context.Users.ToListAsync();
            return Ok(new { data = data });
        }
    }
}   