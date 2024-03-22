using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static List<Filme> filmes = new List<Filme>();
    private static int id = 0;


    // A função CreatedAtAction retorna o que foi criado
    [HttpPost]
    public IActionResult AdicionarFilme([FromBody] Filme filme)
    {
        filme.Id = id++;
        filmes.Add(filme);
        return CreatedAtAction(nameof(RecuperaFilmesporId), new { id = filme.Id }, filme);
    }

    // Skip e take são para paginacao
    [HttpGet]
    public IEnumerable<Filme> RecuperaFilmes([FromQuery] int skip = 0,
        [FromQuery] int take = 50)
    {
        return filmes.Skip(skip).Take(take);
    }

    // IActionResult trás o resultado de uma ação que foi executada
    [HttpGet("{id}")]
    public IActionResult RecuperaFilmesporId(int id)
    {
        var filme = filmes.FirstOrDefault(filme => filme.Id == id);
        if (filme == null) return NotFound();
        return Ok(filme);
    }
}