using System.ComponentModel.DataAnnotations;

namespace API.Paises.Entidades
{
    public class Estado
    {
        public int Id { get; set; }
        [Required]
        public string NombreEstado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEdicion { get; set; }
        public Pais? pais { get; set; }
    }
}
