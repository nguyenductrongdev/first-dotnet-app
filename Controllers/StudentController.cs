using FirstProject.Models.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;
        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Student>> Details(int id)
        {
            var student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAll()
        {
            var students = await _context.Student.ToListAsync();
            return students;
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<Student>> Create([FromBody] Student student)
        {
            _context.Student.Add(student);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Details), new { id = student.Id }, student);
        }
    }
}
