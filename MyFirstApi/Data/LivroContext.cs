using Microsoft.EntityFrameworkCore;
using MyFirstApi.Model;

namespace MyFirstApi.Data
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Livro> Livros { get; set; } //sempre no plural
    }
}