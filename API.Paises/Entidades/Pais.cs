namespace API.Paises.Entidades
{
    public class Pais
    {
        public int Id { get; set; }
        public string NombrePais { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaEdicion { get; set; }
        public List<Estado> Estado { get; set; } = new List<Estado>();
    }
}
