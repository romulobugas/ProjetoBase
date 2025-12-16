using System.ComponentModel.DataAnnotations;

namespace ProjetoBase.API.Models;

public class ObservacaoUpdateRequest
{
    [Required]
    [MaxLength(2000)]
    public string Observacoes { get; set; } = string.Empty;
}
