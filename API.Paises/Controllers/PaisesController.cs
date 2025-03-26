using System.Collections;
using API.Paises.Datos;
using API.Paises.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Paises.Controllers
{
    [ApiController]
    [Route("api/Pais")]
    public class PaisesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PaisesController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<IEnumerable> GetPaises()
        {

            return await _context.Pais.ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Pais>> GetPaisId(int id)
        {
            var pais = await _context.Pais.FirstOrDefaultAsync(x => x.Id == id);
            if (pais is null) 
            {
                return NotFound($"El registro con id {id} no encontrado");
            }

            return pais;
        }

        [HttpPost]
        public async Task<ActionResult> PostPaises(Pais pais)
        {
            pais.FechaCreacion = DateTime.Now;
            pais.FechaEdicion = DateTime.Now;

            _context.Add(pais);
            await _context.SaveChangesAsync();
            return Ok("Registro Creado");

        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> UdpatePaisId(int id, Pais pais)
        {
            if (id != pais.Id)
            {
                return BadRequest("El id no conicide con el registro");
            }
            _context.Update(pais);
            await _context.SaveChangesAsync();
            return Ok($"Registro con id {id} actualizado.");

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeletePaisId(int id)
        {
            var borrarRegistro = await _context.Pais.Where(x => x.Id == id).ExecuteDeleteAsync();
            if (borrarRegistro == 0) 
            {
                return NotFound("El id de registro no fue encontrado.");
            }
            
            return Ok($"Registro con id {id} fue borrado.");
        }

    }
}
