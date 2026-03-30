using Microsoft.AspNetCore.Mvc;
using AvatarApi.Models;
using AvatarApi.Data;
using Microsoft.EntityFrameworkCore;

namespace AvatarApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharactersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CharactersController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var characters = await _context.Characters.ToListAsync();
            return Ok(characters);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var character = await _context.Characters.FirstOrDefaultAsync(c => c.Id == id);
            
            if (character == null)
                return NotFound();

            return Ok(character);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Character character)
        {
            _context.Characters.Add(character);
            await _context.SaveChangesAsync();
            return Ok(character);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Character updatedCharacter)
        {
            if (id != updatedCharacter.Id)
                return BadRequest();

            var character = await _context.Characters.FindAsync(id);

            if (character == null)
                return NotFound();

            character.Name = updatedCharacter.Name;
            character.Element = updatedCharacter.Element;
            character.Nation = updatedCharacter.Nation;
            character.ImageUrl = updatedCharacter.ImageUrl;

            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var character = await _context.Characters.FindAsync(id);

            if (character == null)
                return NotFound();

            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpGet("element/{element}")]
        public async Task<IActionResult> GetByElement(string element)
        {
            var characters = await _context.Characters
                .Where(c => c.Element.ToLower() == element.ToLower())
                .ToListAsync();

            return Ok(characters);
        }
    }
}