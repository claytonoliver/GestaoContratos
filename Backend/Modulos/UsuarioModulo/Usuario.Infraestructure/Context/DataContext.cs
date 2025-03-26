using Usuario.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using ContratUsuarioos.Domain.Entities;

namespace Usuario.Infraestucture.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DataContext()
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
