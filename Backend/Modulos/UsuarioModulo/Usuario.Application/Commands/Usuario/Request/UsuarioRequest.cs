using Contratos.Domain.Enum;

namespace Usuario.Application.Commands.CriarUsuario.Request
{
    public class UsuarioRequest
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public int Role { get; set; }
        public bool Ativo { get; set; }
    }
}
