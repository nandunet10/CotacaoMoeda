using CotacaoMoeda.Modelo;
using Microsoft.EntityFrameworkCore;


namespace CotacaoMoeda.Infra.Entity
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    
        public DbSet<Cotacao> Cotacao { get; set; }
    }
}
