using BooksProject.Data;
using BooksProject.Models;
using Microsoft.AspNetCore.Mvc;

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


        [HttpPost]
        [Route("register")]
        public IActionResult Register(AddUserDTO model)
        {
            model.Password = HashPassword(model.Password);

            Users user = new Users
            {
                EmailAddress = model.EmailAddress,
                Password = model.Password
            };

            _context.users.Add(user);
            _context.SaveChanges();
            return Ok("registration succesful");
        }

        private string HashPassword(string password)
        {
            // Implement secure hashing algorithm
            return password; // Replace this with actual hashing logic
        }
    }
}