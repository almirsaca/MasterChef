using MasterChef.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterChef.Data.Mapping
{
    public class AutorMap
    {
        public static void OnCreateTable(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaAutor>(entity =>
            {
                entity.ToTable("ReceitaAutor", "dbo");
                entity.HasKey(e => e.ReceitaAutorID);
                entity.Property(e => e.ReceitaAutorID).IsRequired().ValueGeneratedOnAdd();
                entity.Property(e => e.StatusItemID).IsRequired();
            });
        }
    }
}
