using MasterChef.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository.Mapping
{
    public static class ReceitaCategoriaMap
    {
        public static void OnCreateTable(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaCategoria>(entity =>
            {
                entity.ToTable("ReceitaCategoria", "dbo");

                entity.HasKey(e => e.ReceitaCategoriaID);
                entity.Property(e => e.ReceitaCategoriaID).IsRequired().ValueGeneratedOnAdd();

                entity.Property(e => e.Ativo).IsRequired();
                entity.Property(e => e.Descricao).HasMaxLength(256).IsRequired();

            });
        }
    }
}
