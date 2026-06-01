using Microsoft.AspNetCore.Mvc;
using ExamApp.Models;

namespace ExamApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var users = new List<User>
            {
                new User { Id = 1, Name = "John Doe", Email = "john@test.com" },
                new User { Id = 2, Name = "Jane Smith", Email = "jane@test.com" }
            };
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(new User { Id = id, Name = $"User {id}", Email = $"user{id}@test.com" });
        }
    }
}