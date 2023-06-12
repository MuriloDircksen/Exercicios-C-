using FilmesApi.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesApi.DTO.Response
{
    public class FilmeDiretorResponseDTO
    {
        [ForeignKey("Filme")]
        public virtual int IdFilme { get; set; }
        public Filme Filme { get; set; }

        [ForeignKey("Diretor")]
        public virtual int IdDiretor { get; set; }
        public Diretor Diretor { get; set; }
    }
}
