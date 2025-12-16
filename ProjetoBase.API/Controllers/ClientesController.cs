using Microsoft.AspNetCore.Mvc;
using ProjetoBase.API.Models;
using ProjetoBase.API.Repositories.Interfaces;

namespace ProjetoBase.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly IClienteRepository _clienteRepository;

    public ClientesController(IClienteRepository clienteRepository)
    {
        _clienteRepository = clienteRepository;
    }

    /// <summary>
    /// Lista clientes com filtros opcionais pelos principais campos.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<ClienteResponse>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetClientes(
        [FromQuery] string? nome,
        [FromQuery] string? documento,
        [FromQuery] string? email,
        [FromQuery] string? contato)
    {
        var clientes = await _clienteRepository.BuscarClientesAsync(nome, documento, email, contato);

        var response = clientes
            .Select(ClienteResponse.FromEntity)
            .ToList();

        return Ok(response);
    }

    /// <summary>
    /// Atualiza apenas o campo de observações de um cliente específico.
    /// </summary>
    [HttpPatch("{id:int}/observacoes")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> AtualizarObservacoes([FromRoute] int id, [FromBody] ObservacaoUpdateRequest request)
    {
        var atualizado = await _clienteRepository.AtualizarObservacoesAsync(id, request.Observacoes);

        if (!atualizado)
        {
            return NotFound();
        }

        return NoContent();
    }
}
