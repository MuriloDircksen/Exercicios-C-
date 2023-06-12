using System;
using System.Collections.Generic;

namespace DBFirstFilmeApi.Models;

public partial class Filme
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Diretor { get; set; } = null!;

    public string Genero { get; set; } = null!;

    public int Duracao { get; set; }
}
