using Contratos.Domain.Enum;

namespace Usuario.Application.Queries.Usuario.Response
{
    public class BuscarUsuarioResponse
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public RoleEnum Role { get; set; }
        public bool Ativo { get; set; }
    }
}
