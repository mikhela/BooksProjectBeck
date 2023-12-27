using BooksProject.Data;
using BooksProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BooksProject.Controllers
{
    [Route("api/books")]
    [ApiController]
    public class BooksController : Controller
    {
        private readonly ApplicationDataContext _context;

        public BooksController(ApplicationDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable<BooksInformation>> GetBooks()
        {
            return await _context.BooksInformation.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BooksInformation>> GetBook(int id)
        {
            if (id <= 0)
                return BadRequest();

            var book = await _context.BooksInformation.FirstOrDefaultAsync(x => x.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

    }
}
