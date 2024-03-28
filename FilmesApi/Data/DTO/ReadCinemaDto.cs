using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTO;

public class ReadCinemaDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public ReadEnderecoDto Endereco { get; set; }
}