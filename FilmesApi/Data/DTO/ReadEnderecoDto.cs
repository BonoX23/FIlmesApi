using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTO;

public class ReadEnderecoDto
{
    public int Id { get; set; }
    public string Logradouro { get; set; }
    public int Numero { get; set; }
}