using BooksProject.Data;
using BooksProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksProject.Controllers
{
    [Route("api/about")]
    [ApiController]
    public class AboutMeController : Controller
    {
        private readonly ApplicationDataContext _context;
        public AboutMeController(ApplicationDataContext context)
        { 
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Aboutme>> GetMyinfos()
        {
            return await _context.aboutme.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Aboutme>> GetMyinfo(int id)
        {
            if (id <= 0)
                return BadRequest();

            var book = await _context.aboutme.FirstOrDefaultAsync(x => x.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }
    }
}
