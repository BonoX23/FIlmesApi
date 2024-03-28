using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTO;

public class CreateEnderecoDto
{
    public string Logradouro { get; set; }
    public int Numero { get; set; }
}