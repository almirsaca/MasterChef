using MasterChef.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterChef.Data.Context
{
    public class ReceitaContext : DbContext
    {
        #region Inicializacao

        public ReceitaContext(string connString) : base(new DbContextOptionsBuilder<ReceitaContext>()
        .UseSqlServer(connString).Options)
        { }

        #endregion // Inicializacao

        #region DbSets

        public DbSet<Receitas> Receitas { get; set; }
        public DbSet<ReceitaCategoria> ReceitaCategoria { get; set; }
        public DbSet<ReceitaAutor> ReceitaAutor { get; set; }
        public DbSet<ReceitaIngredientes> ReceitaIngredientes { get; set; }
        public DbSet<ReceitaPrepraro> ReceitaPrepraro { get; set; }
        

        #endregion // DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receitas>().ToTable("Receitas");
            modelBuilder.Entity<ReceitaCategoria>().ToTable("ReceitaCategoria");
            modelBuilder.Entity<ReceitaIngredientes>().ToTable("ReceitaIngredientes");
            modelBuilder.Entity<ReceitaPrepraro>().ToTable("ReceitaPrepraro");
            modelBuilder.Entity<ReceitaAutor>().ToTable("ReceitaAutor");
        }
    }
}
