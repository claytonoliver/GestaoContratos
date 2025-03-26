using Contratos.Domain.Enum;
using ContratUsuarioos.Domain.Entities;
using MediatR;
using Usuario.Application.Commands.CriarUsuario.Response;
using Usuario.Application.Commands.Usuario;
using Usuario.Application.Services.Interfaces;
using Usuario.Infraestucture.Context;

namespace Contratos.Application.Handlers.Command
{
    public class UsuarioCommandHandler :
        IRequestHandler<CriarUsuarioCommand, UsuarioResponse>
    {
        private readonly DataContext _context;
        private readonly IPasswordHasher _passwordHasher;
        public UsuarioCommandHandler(DataContext context, IPasswordHasher hasher)
        {
            _context = context;
            _passwordHasher = hasher;
        }

        public async Task<UsuarioResponse> Handle(CriarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var Passwordhash = _passwordHasher.GerarHash(request.Usuario.Senha);

            var usuario = new UsuarioModel(
                request.Usuario.Nome,
                request.Usuario.Email,
                Passwordhash,
                request.Usuario.Role,
                request.Usuario.Ativo);

            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();

            return new UsuarioResponse
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Role = usuario.Role,
                Ativo = usuario.Ativo
            };
        }
    }
}
