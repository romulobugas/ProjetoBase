using System;

namespace ProjetoBase.API.Domain.Cliente;

public class Cliente
{
    public virtual int Id { get; set; }
    public virtual string? Nome { get; set; }
    public virtual string? CpfCnpj { get; set; }
    public virtual string? RgIe { get; set; }
    public virtual DateTime? DataNascFund { get; set; }
    public virtual string? Endereco { get; set; }
    public virtual string? Contato { get; set; }
    public virtual string? Email { get; set; }
    public virtual string? Observacoes { get; set; }
}
