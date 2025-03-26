using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Paises.Entidades
{
    public class Pais
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string NombrePais { get; set; }
        public List<Estado> Estado { get; set; } = new List<Estado>();
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEdicion { get; set; }
        
    }
}
