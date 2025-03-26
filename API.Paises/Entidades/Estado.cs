using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Paises.Entidades
{
    public class Estado
    {

        public int Id { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        public string NombreEstado { get; set; }
        [Required]
        public int IdPais { get; set; }
        public Pais? Pais { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEdicion { get; set; }

    }
}
