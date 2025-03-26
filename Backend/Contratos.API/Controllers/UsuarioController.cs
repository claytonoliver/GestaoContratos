using MediatR;
using Microsoft.AspNetCore.Mvc;
using Usuario.Application.Commands.Usuario;
using Usuario.Application.Queries.Usuario;


namespace GerenciamentoContratos.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IMediator _mediator;
        public UsuarioController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> CriarUsuario([FromBody] CriarUsuarioCommand command)
        {
            var contrato = await _mediator.Send(command);

            return Created("Criado", contrato);
        }
        [HttpGet]
        public async Task<IActionResult> BuscarTodosUsuarios()
        {
            var contrato = await _mediator.Send(new BuscarUsuariosQuery());
            if (contrato == null)
                return NotFound();
            return Ok(contrato);
        }
    }
}