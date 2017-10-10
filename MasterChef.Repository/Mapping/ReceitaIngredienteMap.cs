using MasterChef.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository.Mapping
{
    public static class ReceitaIngredienteMap
    {
        public static void OnCreateTable(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaIngrediente>(entity =>
            {
                entity.ToTable("ReceitaIngrediente", "dbo");

                entity.HasKey(e => e.ReceitaIngredienteID);
                entity.Property(e => e.ReceitaIngredienteID).IsRequired().ValueGeneratedOnAdd();

                entity.Property(e => e.ReceitaID).IsRequired();
                entity.Property(e => e.Ativo).IsRequired();
                entity.Property(e => e.Quantidade).IsRequired();
                entity.Property(e => e.IngredienteID).IsRequired();
                
                entity.HasOne(e => e.Receita).WithMany(e => e.Ingredientes).HasForeignKey(e => e.ReceitaID);
                entity.HasOne(e => e.Ingrediente).WithMany(e => e.Ingredientes).HasForeignKey(e => e.IngredienteID);
            });
        }
    }
}
