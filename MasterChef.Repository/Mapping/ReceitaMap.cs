using MasterChef.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository.Mapping
{
    public static class ReceitaMap
    {
        public static void OnCreateTable(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receita>(entity =>
            {
                entity.ToTable("Receita", "dbo");

                entity.HasKey(e => e.ReceitaID);
                entity.Property(e => e.ReceitaID).IsRequired().ValueGeneratedOnAdd();

                entity.Property(e => e.Ativo).IsRequired();
                entity.Property(e => e.Titulo).HasMaxLength(256).IsRequired();

                entity.HasOne(e => e.ReceitaAutor).WithMany(e => e.Receitas).HasForeignKey(e => e.ReceitaAutorID);
                entity.HasOne(e => e.ReceitaCategoria).WithMany(e => e.Receitas).HasForeignKey(e => e.ReceitaCategoriaID);
            });
        }
    }
}
