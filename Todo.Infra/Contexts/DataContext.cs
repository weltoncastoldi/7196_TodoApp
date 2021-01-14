using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore;
using Todo.Dominio.Entidades;

namespace Todo.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //Todo nome da tebela no banco
        public DbSet<TodoItem> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoItem>().Property(x => x.Id);
            modelBuilder.Entity<TodoItem>().Property(x => x.User);
        }
    }
}
