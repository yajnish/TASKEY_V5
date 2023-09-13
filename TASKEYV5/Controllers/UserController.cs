using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TASKEYV5.Data;
using TASKEYV5.Models.Domains;
using TASKEYV5.Models.DTO;

namespace TASKEYV5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public UserController(ApplicationDbContext dbContext) { 
            this.dbContext = dbContext;
        }
        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUserRequestDto request)
        {
            var user = new User
            {
                FirstName = request.FirstName,
                SecondName = request.SecondName,
                Position = request.Position,
                IsManager = request.IsManager

            };
            await dbContext.User.AddAsync(user);
            await dbContext.SaveChangesAsync();

            var response = new UserDto
            {
                Id = user.Id,
                FirstName = user.FirstName,
                SecondName= user.SecondName,
                Position = user.Position,
                IsManager = user.IsManager

            };

            return Ok(user);
        }
    }
}
