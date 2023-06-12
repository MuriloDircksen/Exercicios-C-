using System.ComponentModel.DataAnnotations;

namespace FilmesApi.DTO
{
    public class FilmeDiretorDTO
    {
        [Required]
        public int IdFilme { get; set; }
        [Required]
        public int IdDiretor { get; set; }
    }
}
