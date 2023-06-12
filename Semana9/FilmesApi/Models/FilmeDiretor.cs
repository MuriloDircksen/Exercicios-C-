using System.ComponentModel.DataAnnotations.Schema;

namespace FilmesApi.Models
{
    public class FilmeDiretor
    {
        public int Id { get; set; }
        
        [ForeignKey("Filme")]
        public virtual int IdFilme {get; set;}
        public Filme Filme { get; set;}

        [ForeignKey("Diretor")]
        public virtual int IdDiretor { get; set;}
        public Diretor Diretor { get; set;}
    }
}
