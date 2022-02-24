using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrimeraApi.Database;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace PrimeraApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly MyDbContext _context;

        public PersonaController (MyDbContext context)
        {
            _context = context; 
        }

    

        [HttpGet]
        async public Task<ActionResult<IEnumerable<Persona>>> GetPersonas()
        {
            try
            {
                return await _context.Personas.ToListAsync();
            }
            catch
            {
                return NoContent();
            }
           
        }

        [HttpGet("{id:int}")]
        async public Task<ActionResult<Persona>> GetPersona(int id)
        {
            try
            {
                return await _context.Personas.Where(p=> p.Id == id).FirstAsync();
            }
            catch
            {
                return NoContent();
            }

        }

        [HttpPost("alta")]
        public ActionResult<Persona> AltaPersona(Persona persona)
        {
            if (persona == null)
            {
                return BadRequest();
            }
            else
            {
                _context.Personas.Add(persona).State = EntityState.Added;
                _context.SaveChanges();
                return persona;
            }
        }
        [HttpPut("modificar/{id:int}")]
        public ActionResult<Persona> ModificacionPersona(int id, Persona persona)
        {
            if (persona == null && id < 1)
            {
                return BadRequest();
            }
            else
            {
                Persona p = _context.Personas.Where(p=>p.Id == id).First();
                p.Nombre = persona.Nombre;
                p.Apellido = persona.Apellido;
                p.Sexo = persona.Sexo;
                _context.Personas.Update(p).State = EntityState.Modified;
                _context.SaveChanges();
                return persona;
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult EliminarPersona(int id)
        {
            if (id < 1)
            {
                return BadRequest();
            }
            else
            {
                Persona p = _context.Personas.Where(_p => _p.Id == id).First();
                _context.Personas.Remove(p).State = EntityState.Deleted;
                _context.SaveChanges();
                return Ok();
            }
        }
 


    }
}
