using MasterChef.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository.Mapping
{
    public static class ReceitaAutorMap
    {
        public static void OnCreateTable(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaAutor>(entity =>
            {
                entity.ToTable("ReceitaAutor", "dbo");

                entity.HasKey(e => e.ReceitaAutorID);
                entity.Property(e => e.ReceitaAutorID).IsRequired().ValueGeneratedOnAdd();

                entity.Property(e => e.Ativo).IsRequired();
                entity.Property(e => e.Nome).HasMaxLength(256).IsRequired();

            });
        }
    }
}
