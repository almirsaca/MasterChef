using MasterChef.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterChef.Data.Context
{
    public class ReceitaContext : DbContext
    {
        #region Inicializacao

        public ReceitaContext(string connString) : base(new DbContextOptionsBuilder<ReceitaContext>()
        .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=MasterChef;Trusted_Connection=True;MultipleActiveResultSets=true").Options)
        { }

        #endregion // Inicializacao

        #region DbSets

        public DbSet<Receita> Receita { get; set; }
        public DbSet<ReceitaCategoria> ReceitaCategoria { get; set; }
        public DbSet<ReceitaAutor> ReceitaAutor { get; set; }
        public DbSet<ReceitaIngrediente> ReceitaIngredientes { get; set; }
        public DbSet<ReceitaPrepraro> ReceitaPrepraro { get; set; }
        

        #endregion // DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receita>().ToTable("Receita");
            modelBuilder.Entity<ReceitaCategoria>().ToTable("ReceitaCategoria");
            modelBuilder.Entity<ReceitaIngrediente>().ToTable("ReceitaIngrediente");
            modelBuilder.Entity<ReceitaPrepraro>().ToTable("ReceitaPrepraro");
            modelBuilder.Entity<ReceitaAutor>().ToTable("ReceitaAutor");
        }
    }
}
