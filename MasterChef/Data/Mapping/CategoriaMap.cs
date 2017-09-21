using MasterChef.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace MasterChef.Data.Mapping
{
    public class CategoriaMap
    {
        public static void OnCreateTable(ref ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ReceitaCategoria>(entity =>
            {
                entity.ToTable("ReceitaCategoria", "dbo");
                entity.HasKey(e => e.ReceitaCategoriaID);
                entity.Property(e => e.ReceitaCategoriaID).IsRequired().ValueGeneratedOnAdd();
                entity.Property(e => e.StatusItemID).IsRequired();
            });
        }
    }
}
