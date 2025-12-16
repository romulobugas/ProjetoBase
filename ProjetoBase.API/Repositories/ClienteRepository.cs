using NHibernate;
using NHibernate.Linq;
using ProjetoBase.API.Domain.Cliente;
using ProjetoBase.API.Repositories.Interfaces;

namespace ProjetoBase.API.Repositories;

public class ClienteRepository : IClienteRepository
{
    private readonly ISessionFactory _sessionFactory;

    public ClienteRepository(ISessionFactory sessionFactory)
    {
        _sessionFactory = sessionFactory;
    }

    public async Task<IReadOnlyCollection<Cliente>> BuscarClientesAsync(string? nome, string? documento, string? email, string? contato)
    {
        using var session = _sessionFactory.OpenSession();

        IQueryable<Cliente> query = session.Query<Cliente>();

        if (!string.IsNullOrWhiteSpace(nome))
        {
            query = query.Where(c => c.Nome != null && c.Nome.Contains(nome));
        }

        if (!string.IsNullOrWhiteSpace(documento))
        {
            query = query.Where(c => c.CpfCnpj != null && c.CpfCnpj.Contains(documento));
        }

        if (!string.IsNullOrWhiteSpace(email))
        {
            query = query.Where(c => c.Email != null && c.Email.Contains(email));
        }

        if (!string.IsNullOrWhiteSpace(contato))
        {
            query = query.Where(c => c.Contato != null && c.Contato.Contains(contato));
        }

        var clientes = await query.ToListAsync();
        return clientes;
    }

    public async Task<Cliente?> ObterPorIdAsync(int id)
    {
        using var session = _sessionFactory.OpenSession();
        return await session.GetAsync<Cliente>(id);
    }

    public async Task<bool> AtualizarObservacoesAsync(int id, string observacoes)
    {
        using var session = _sessionFactory.OpenSession();
        using var transaction = session.BeginTransaction();

        var cliente = await session.GetAsync<Cliente>(id);

        if (cliente is null)
        {
            return false;
        }

        cliente.Observacoes = observacoes;
        await session.UpdateAsync(cliente);

        await transaction.CommitAsync();
        return true;
    }
}
