using BooksProject.Data;
using BooksProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksProject.Controllers
{
    [Route("api/Users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDataContext _context;
        public UsersController(ApplicationDataContext context)
        {
            _context = context;
        }

        [HttpPost("registration")]

        public async Task<IActionResult> Register(AddUserDTO model)
        { 

            if(!ModelState.IsValid)
            { 
                return BadRequest(ModelState);
            }

            if (await _context.users.AnyAsync(x => x.EmailAddress == model.EmailAddress))
            {
                return Conflict("Email already exists");
            }

            var newUser = new Users
            {
                EmailAddress = model.EmailAddress,
                Password = model.Password
            };

            _context.users.Add(newUser);
            await _context.SaveChangesAsync();


            return Ok("registration successful");
        }


        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var user = await _context.users.FirstOrDefaultAsync(x => x.EmailAddress == model.EmailAddress);

            if (user == null)
            {
                return NotFound("User not found");
            }

            if (user.Password != model.Password)
            {
                return Unauthorized("Invalid password");
            }

            // You might generate a token here if using authentication mechanisms like JWT

            return Ok("Login successful");
        }


    }
}