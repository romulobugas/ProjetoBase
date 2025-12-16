using ProjetoBase.API.Domain.Cliente;

namespace ProjetoBase.API.Models;

public record ClienteResponse(
    int Id,
    string? Nome,
    string? CpfCnpj,
    string? RgIe,
    DateTime? DataNascFund,
    string? Endereco,
    string? Contato,
    string? Email,
    string? Observacoes)
{
    public static ClienteResponse FromEntity(Cliente cliente) => new(
        cliente.Id,
        cliente.Nome,
        cliente.CpfCnpj,
        cliente.RgIe,
        cliente.DataNascFund,
        cliente.Endereco,
        cliente.Contato,
        cliente.Email,
        cliente.Observacoes);
}
