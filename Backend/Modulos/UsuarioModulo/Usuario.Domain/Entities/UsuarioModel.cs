using Contratos.Domain.Enum;
using Usuario.Domain.Entities;

namespace ContratUsuarioos.Domain.Entities
{
    public sealed class UsuarioModel : Entity
    {
        public string Nome { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public string Senha { get; private set; } = string.Empty;
        public int Role { get; private set; }
        public bool Ativo { get; private set; }
        //public string RoleName => Role.GetRoleName();

        private UsuarioModel() { }

        public UsuarioModel(string nome, string email, string senha, int role, bool ativo)
        {
            Id = Guid.NewGuid();
            SetNome(nome);
            SetEmail(email);
            Senha = senha;
            Role = role;
            Ativo = ativo;
        }

        public void SetNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome não pode ser vazio.");

            Nome = nome;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
                throw new ArgumentException("E-mail inválido.");

            Email = email.ToLower();
        }

        public void Ativar() => Ativo = true;
        public void Desativar() => Ativo = false;
    }
}
