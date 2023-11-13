using Microsoft.EntityFrameworkCore;
using Padel.Core.Entities;

namespace DemoPadel.Data;

public class PadelDataContext: DbContext
{
    public PadelDataContext(DbContextOptions<PadelDataContext> opzioni): base(opzioni)
    {
    }
    public DbSet<IstruttorePadel> IstruttoriPadel { get; set; }
    public DbSet<Lezione> Lezioni { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
 
        modelBuilder.Entity<Lezione>().Property(x => x.Id)
            .HasColumnName("IdLezione");

        base.OnModelCreating(modelBuilder);
    }
}
