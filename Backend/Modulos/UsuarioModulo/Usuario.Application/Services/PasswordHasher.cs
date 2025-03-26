using Usuario.Application.Services.Interfaces;

namespace Usuario.Application.Services
{
    public class PasswordHasher : IPasswordHasher
    {
        public string GerarHash(string senha)
        {
            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            return BCrypt.Net.BCrypt.HashPassword(senha, salt);
        }

        public bool VerificarSenha(string senha, string hash)
        {
            return BCrypt.Net.BCrypt.Verify(senha, hash);
        }
    }
}
