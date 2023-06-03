using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FilmesApi.Controllers
{
    
    [Route("api/v{version:apiVersion}/filmes")]
    [ApiVersion ("1.0")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        // GET: api/<FilmesController>
        /// <summary>
        /// Recupera uma lista de filmes do banco de dados
        /// </summary>
        /// <returns>Informações dos filmes buscados</returns>
        /// <response code="200">Com a lista de filmes presentes na base de dados</response>
        [ProducesResponseType(StatusCodes.Status200OK)] //configurações do endpoint obrigatorio
        [HttpGet]
        public IEnumerable<Filme> Get()
        {
            return MockFilmes.Filmes;
        }

        // GET api/<FilmesController>/5
        /// <summary>
        /// Recupera um filme no banco de dados usando seu id
        /// </summary>
        /// <param name="id">Id do filme a ser recuperado no banco</param>
        /// <returns>Informações do filme buscado</returns>
        /// <response code="200">Caso o id seja existente na base de dados</response>
        /// <response code="404">Caso o id seja inexistente na base de dados</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet("{id}")]
        public IActionResult Get(int id) //representa as definições de status code que retorna no endpoint
        {
            Filme filme = MockFilmes.Filmes.FirstOrDefault(x=> x.Id == id);

            if (filme == null)
            {
                return NotFound();
            }
            
            return Ok(filme);
        }

        // POST api/<FilmesController>
        /// <summary>
        /// Adiciona um filme ao banco de dados
        /// </summary>
        /// <param name="filme">Objeto com os campos necessários para criação de um filme</param>
        /// <returns>Dados do filme cadastrado</returns>
        /// <response code="201">Caso inserção seja feita com sucesso</response>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public IActionResult Post([FromBody] Filme filme)
        {
            MockFilmes.Filmes.Add(filme);

            return CreatedAtAction(nameof(Get), new {id = filme.Id}, filme);
        }

        // PUT api/<FilmesController>/5
        /// <summary>
        /// Atualiza um filme no banco de dados usando seu id
        /// </summary>
        /// <param name="id">Id do filme a ser atualizado no banco</param>
        /// <param name="filme">Objeto com os campos necessários para atualização de um filme</param>
        /// <returns>Sem conteúdo de retorno</returns>
        /// <response code="204">Caso o id seja existente na base de dados e o filme tenha sido atualizado</response>
        /// <response code="404">Caso o id seja inexistente na base de dados</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Filme value)
        {
            Filme filme = MockFilmes.Filmes.FirstOrDefault(x => x.Id == id);

            if(filme is null)
            {
                return NotFound();
            }
            var index = MockFilmes.Filmes.IndexOf(filme);
            if(index != -1)
            {
                MockFilmes.Filmes[index] = value;
            }
            return NoContent();
        }

        // DELETE api/<FilmesController>/5
        /// <summary>
        /// Deleta um filme usando seu id
        /// </summary>
        /// <param name="id">Id do filme a ser removido da base de dados</param>
        /// <returns>Sem conteúdo de retorno</returns>
        /// <response code="204">Caso o id seja existente na base de dados e o filme tenha sido removido</response>
        /// <response code="404">Caso o id seja inexistente na base de dados</response>
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Filme filmeUpdate = MockFilmes.Filmes.FirstOrDefault(x=> x.Id == id);

            if(filmeUpdate is null)
            {
                return NotFound();
            }

            MockFilmes.Filmes.Remove(filmeUpdate);
            return NoContent();
        }
    }
}
