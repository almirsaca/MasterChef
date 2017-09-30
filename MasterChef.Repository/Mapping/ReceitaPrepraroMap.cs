using MasterChef.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterChef.Repository.Mapping
{
    public class ReceitaPrepraroMap
    {
        public static void OnCreateTable(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaPrepraro>(entity =>
            {
                entity.ToTable("ReceitaPrepraro", "dbo");

                entity.HasKey(e => e.ReceitaPrepraroID);
                entity.Property(e => e.ReceitaPrepraroID).IsRequired().ValueGeneratedOnAdd();

                entity.Property(e => e.ReceitaID).IsRequired();
                entity.Property(e => e.Ativo).IsRequired();
                entity.Property(e => e.ModoPreparo).IsRequired();
            });
        }
    }
}
