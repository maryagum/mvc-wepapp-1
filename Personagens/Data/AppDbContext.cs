using Microsoft.EntityFrameworkCore;
using Personagens.Models;
public class AppDbContext : DbContext
{
public DbSet<Personagem> Personagens { get; set; }
public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    //converte a entidade Personagem em uma tabela no banco de dados
    modelBuilder.Entity<Personagem>().ToTable("Personagem");
    // insere os dados na tabela Personagem
    modelBuilder.Entity<Personagem>().HasData(
    new Personagem { Id = 1, Nome = "Entrapta", Altura = 1.60,
    DataEstreia = Convert.ToDateTime("13/11/2018"), IsAlive = true },

    new Personagem { Id = 2, Nome = "Rhaenyra Targaryen", Altura = 1.71,
    DataEstreia = Convert.ToDateTime("20/11/2018"), IsAlive = false },

    new Personagem { Id = 3, Nome = "Alicent Hightower", Altura = 1.66,
    DataEstreia = Convert.ToDateTime("20/11/2018"), IsAlive = true }
    );
    }

}