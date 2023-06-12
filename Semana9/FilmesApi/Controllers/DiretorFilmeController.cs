using AutoMapper;
using FilmesApi.Context;
using FilmesApi.DTO;
using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FilmesApi.Controllers
{
    [Route("api/v{version:apiVersion}/diretorfilmes")]
    [ApiVersion("1.0")]
    [ApiController]
    public class DiretorFilmeController : Controller
    {
        
        private readonly FilmeContext _context;
        public DiretorFilmeController(FilmeContext filmeContext)
        {
            _context = filmeContext;
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.FilmeDiretores
                            .Include(x => x.Diretor)
                            .Include(x => x.Filme)
                            .ToListAsync());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]

        public async Task<IActionResult> Get(int id)
        {
            var filmesDiretor = await _context.FilmeDiretores
                            .Include(x => x.Diretor)
                            .Include(x => x.Filme)
                            .FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(true);

            if (filmesDiretor is null)
            {
                return NotFound();
            }
            return Ok(filmesDiretor);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<FilmeDiretor>> Post([FromBody] FilmeDiretorDTO filmesDiretorDto)
        {
            var configuration = new MapperConfiguration( cfg => cfg.CreateMap<FilmeDiretorDTO, FilmeDiretor>());
            //criando um mapeamento da classe Filme diretor pela classe FilemDiretorDTO

            var mapper = configuration.CreateMapper(); //cria o mapeamento
            FilmeDiretor filmesDiretor = mapper.Map<FilmeDiretor>(filmesDiretorDto);
            _context.FilmeDiretores.Add(filmesDiretor);

            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = filmesDiretor.Id }, filmesDiretor);

        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Put(int id, [FromBody] FilmeDiretor filmeDiretor)
        {
            bool existeFilmeDiretor = await _context.FilmeDiretores
                                                    .AnyAsync(x => x.Id == id).ConfigureAwait(true);

            if (!existeFilmeDiretor)
            {
                return NotFound();
            }

            _context.Entry(filmeDiretor).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();

        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Delete(int id)
        {
            var filmeDiretor = await _context.FilmeDiretores
                                .Include(x => x.Filme)
                                .Include(x => x.Diretor)
                                .FirstOrDefaultAsync(x => x.Id == id)
                                .ConfigureAwait(true);

            if (filmeDiretor is null)
            {
                return NotFound();
            }

            _context.FilmeDiretores.Remove(filmeDiretor);

            await _context.SaveChangesAsync();

            return NoContent();
        
        }
    }
}
