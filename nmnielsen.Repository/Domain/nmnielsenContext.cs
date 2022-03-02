using Microsoft.EntityFrameworkCore;
using nmnielsen.Repository.Entities;

namespace nmnielsen.Repository.Domain;
public class NmnielsenContext : DbContext
{
    public NmnielsenContext() { }
    public NmnielsenContext(DbContextOptions<NmnielsenContext> optionsBuilder) : base(optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Project table
        //Keys And Relations
        modelBuilder.Entity<Project>().HasKey(p => p.Id);

        //Properties
        modelBuilder.Entity<Project>().Property(p => p.StartDate).HasDefaultValueSql("GetDate()");
        modelBuilder.Entity<Project>().Property(p => p.IsDeleted).HasDefaultValue(false);

        //Data
        modelBuilder.Entity<Project>().HasData(
            new Project { Id = 1,
                Imagename = "nmnielsen.dk_hjemmesiden",
                Name = "nmnielsen.dk hjemmesiden", 
                ShortDescription = "Det her projekt er den side du er på nu.", 
                Description = "I marts 2022 bestemte jeg mig for at lave en hjemmeside, hvor jeg kunne dele min projecter og fortælle lidt om mig selv, dette er den hjemmeside du ser det her på. " +
                "Formålet med projektet var bare som sagt at kunne vise hvad jeg har arbejdet med og for at kunne fortælle lidt om mig selv, men jeg lavede den også for at kunne få " +
                "et sted jeg kunne bruge som et sandbox miljø til at øve og blive bedre til de ting jeg lære igennem tiden.", 
                StartDate=DateTime.Parse("01-03-2022") }
            );
        #endregion
    }

    #region Table Creations
    public DbSet<Project> Projects { get; set; }
    #endregion

}