using Usuario.Application.Queries.Usuario.Response;
using MediatR;

namespace Usuario.Application.Queries.Usuario
{
    public record BuscarUsuariosQuery() : IRequest<IEnumerable<BuscarUsuarioResponse>>;

}
