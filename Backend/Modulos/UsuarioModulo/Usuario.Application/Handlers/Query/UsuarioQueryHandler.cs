using Contratos.Domain.Enum;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Usuario.Application.Queries.Usuario;
using Usuario.Application.Queries.Usuario.Response;
using Usuario.Infraestucture.Context;

namespace Usuario.Application.Handlers.Query
{
    public class UsuarioQueryHandler : IRequestHandler<BuscarUsuariosQuery, IEnumerable<BuscarUsuarioResponse>>
    {
        private readonly DataContext _context;

        public UsuarioQueryHandler(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BuscarUsuarioResponse>> Handle(BuscarUsuariosQuery request, CancellationToken cancellationToken)
        {
            var usuarios =  await _context.Usuarios.ToListAsync();

            return usuarios.Select(usuario => new BuscarUsuarioResponse
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Role = (RoleEnum)usuario.Role,
                Ativo = usuario.Ativo
            });
        }
    }
}
