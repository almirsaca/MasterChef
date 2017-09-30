using MasterChef.Domain.Entities;
using MasterChef.Repository.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MasterChef.Repository
{

    public class MasterChefContext : DbContext
    {
        public MasterChefContext()
        {
            this.Database.EnsureCreated();
        }

        private DbSet<Usuario> Usuario { get; set; }
        private DbSet<Receita> Receita { get; set; }
        private DbSet<ReceitaAutor> ReceitaAutor { get; set; }
        private DbSet<ReceitaCategoria> ReceitaCategoria { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            ReceitaMap.OnCreateTable(ref modelBuilder);
            ReceitaAutorMap.OnCreateTable(ref modelBuilder);
            ReceitaCategoriaMap.OnCreateTable(ref modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SqlExpress;Initial Catalog=MasterChef;Integrated Security=True;Language=portuguese;");
        }
    }
}
