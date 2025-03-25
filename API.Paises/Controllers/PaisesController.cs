using Microsoft.AspNetCore.Mvc;

namespace API.Paises.Controllers
{
    [ApiController]
    [Route("api/Autores")]
    public class PaisesController : Controller
    {
        [HttpGet]
        public string GetPaises() {
            return "Devuelve todos los países";

        }

        [HttpPost]
        public string PostPais()
        {
            return "Inserta un nuevo país";

        }

        [HttpPut]
        public string  UpdatePaise()
        {
            return "Actualiza un registro de un país";

        }

        [HttpDelete]
        public string DeletePaís()
        {
            return "Elimina un registro de un país";
        }
        
    }
}
