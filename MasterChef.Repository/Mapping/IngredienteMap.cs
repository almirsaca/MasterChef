using MasterChef.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository.Mapping
{
    public static class IngredienteMap
    {
        public static void OnCreateTable(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingrediente>(entity =>
            {
                entity.ToTable("Receita", "dbo");

                entity.HasKey(e => e.IngredienteID);
                entity.Property(e => e.IngredienteID).IsRequired().ValueGeneratedOnAdd();

                entity.Property(e => e.Ativo).IsRequired();

            });
        }
    }
}
