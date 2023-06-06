using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Models
{
    public class Filme
    {
        //[Key] sempre que o id for o primeiro item e ter nome id, já reconhece automatico        
        public int Id { get; set; }

        [Required(ErrorMessage= "Campo nome de preenchimento obigatório!")]
        [MaxLength(200, ErrorMessage = "Tamanho máximo de 200 caracteres!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo diretor de preenchimento obigatório!")]
        [MaxLength(100, ErrorMessage = "Tamanho máximo de 100 caracteres!")]
        public string Diretor { get; set; }

        [Required(ErrorMessage = "Campo genero de preenchimento obigatório!")]
        [MaxLength(50, ErrorMessage = "Tamanho máximo de 50 caracteres!")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "Campo Duração de preenchimento obigatório!")]
        [Range(1,360, ErrorMessage = "Tamanho minimo de 1 e máximo de 360!")]
        public int Duracao { get; set; }

    }
}
