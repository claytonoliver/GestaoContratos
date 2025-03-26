using Usuario.Application.Commands.CriarUsuario.Request;
using Usuario.Application.Commands.CriarUsuario.Response;
using MediatR;

namespace Usuario.Application.Commands.Usuario
{
    public record CriarUsuarioCommand(UsuarioRequest Usuario) : IRequest<UsuarioResponse>;

}
