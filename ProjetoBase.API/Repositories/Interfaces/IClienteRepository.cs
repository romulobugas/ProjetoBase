using ProjetoBase.API.Domain.Cliente;

namespace ProjetoBase.API.Repositories.Interfaces;

public interface IClienteRepository
{
    Task<IReadOnlyCollection<Cliente>> BuscarClientesAsync(string? nome, string? documento, string? email, string? contato);
    Task<Cliente?> ObterPorIdAsync(int id);
    Task<bool> AtualizarObservacoesAsync(int id, string observacoes);
}
