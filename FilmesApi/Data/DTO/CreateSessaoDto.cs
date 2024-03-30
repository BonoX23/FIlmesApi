using System.ComponentModel.DataAnnotations;

namespace FilmesApi.Data.DTO;

public class CreateSessaoDto
{
    [Required]
    public int FilmeId { get; set; }
    public int CinemaId { get; set; }
}