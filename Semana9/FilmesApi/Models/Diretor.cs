using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Diretor
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="Campo obrigatório")]
        [MaxLength(200, ErrorMessage ="Este campo aceita até 200 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo precisa mais 2 caracteres")]
        public string Nome { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "Este campo aceita até 200 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo precisa mais 2 caracteres")]
        public string Telefone { get; set; }
    }
}
