using System.Data.Entity;

namespace Administra.Models
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext() : base("name=MinhaConexao")
        {
        }

        public DbSet<Usuario>? Usuarios { get; set; }
    }
}
