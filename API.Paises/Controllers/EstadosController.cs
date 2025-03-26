using System.Collections;
using API.Paises.Datos;
using API.Paises.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Paises.Controllers
{
    [ApiController]
    [Route("api/Estado")]
    public class EstadosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstadosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IEnumerable> GetEstados()
        {

            return await _context.Estados
                .Include(x => x.Pais)
                .ToListAsync();
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Estado>> GetEstadoId(int id)
        {
            var estado = await _context.Estados
                .Include(x=> x.Pais)
                .FirstOrDefaultAsync(x => x.Id == id);
            if (estado is null)
            {
                return NotFound($"El registro con id {id} no encontrado");

            }

            return estado;
        }

        [HttpPost]
        public async Task<ActionResult> PostEstado(Estado estado)
        {
            var existePais = await _context.Pais.AnyAsync(x => x.Id == estado.IdPais);
            if (!existePais)
            {
                return BadRequest($"El país con id {estado.IdPais} no existe.");
            }
            _context.Add(estado);
            await _context.SaveChangesAsync();
            return Ok("Registro Creado");
        }

        [HttpPut("{idEstado:int}")]
        public async Task<ActionResult> UdpateEstadoId(int idEstado, Estado estado)
        {
            if (idEstado != estado.Id)
            {
                return BadRequest("El id no conicide con el registro del estado.");
            }

            var existePais = await _context.Pais.AnyAsync(x => x.Id == estado.IdPais);
            if (!existePais)
            {
                return BadRequest($"El país con Id {estado.IdPais} no existe");
            }

            _context.Update(estado);
            await _context.SaveChangesAsync();
            return Ok($"Registro con id {idEstado} actualizado.");

        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteEstadoId(int id)
        {
            var borrarRegistro = await _context.Estados.Where(x => x.Id == id).ExecuteDeleteAsync();
            if (borrarRegistro == 0)
            {
                return NotFound("El id de registro no fue encontrado.");
            }

            return Ok($"Registro con id {id} fue borrado.");
        }

    }
}
