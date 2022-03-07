using Microsoft.EntityFrameworkCore;
using nmnielsen.Repository.Entities;

namespace nmnielsen.Repository.Domain;
public class NMNielsenContext : DbContext
{
    public NMNielsenContext() { }
    public NMNielsenContext(DbContextOptions<NMNielsenContext> optionsBuilder) : base(optionsBuilder) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Project table
        //Keys And Relations
        modelBuilder.Entity<Project>().HasKey(p => p.Id);

        //Properties
        modelBuilder.Entity<Project>().Property(p => p.Imagename).HasDefaultValue("No_Image_Icon.png");
        modelBuilder.Entity<Project>().Property(p => p.StartDate).HasDefaultValueSql("GetDate()");
        modelBuilder.Entity<Project>().Property(p => p.IsHidden).HasDefaultValue(false);
        modelBuilder.Entity<Project>().Property(p => p.IsDeleted).HasDefaultValue(false);

        //Data
        modelBuilder.Entity<Project>().HasData(
            new Project { Id = 1,
                Imagename = "nmnielsen_hjemmesiden.jpg",
                Name = "nmnielsen hjemmesiden", 
                ShortDescription = "Det her projekt er den side du er på lige nu.", 
                Description = "I marts 2022 bestemte jeg mig for at lave en hjemmeside, hvor jeg kunne dele min projekter og fortælle lidt om mig selv, dette er den hjemmeside du ser det her på. " +
                "Formålet med projektet var bare som sagt at kunne vise hvad jeg har arbejdet med og for at kunne fortælle lidt om mig selv, men jeg lavede den også for at kunne få " +
                "et sted jeg kunne bruge som et sandbox miljø til at øve og blive bedre til de ting jeg lærer igennem tiden.", 
                StatusMessage = "Igangværende",
                StartDate = DateTime.Parse("01-03-2022 21:00") },

            new Project { Id = 2, 
                Name = "MachineNote App",
                ShortDescription = "App til at notere maskiner og andre ting ned.",
                Description = "Dette projekt er en app man kan bruge til at notere maskiner og andre ting ned i, da projektet lige er startet er der ikke så meget at skrive om det i nu. " +
                "Hvad jeg kan skrive er at projektet er oprette da min far har efterspurgt en app han kunne bruge oppe på hans arbejde, så han kan holde log på de maskiner han har serviceret.",
                StatusMessage = "Planlagt",
                StartDate = DateTime.Parse("02-03-2022 18:00")
            }
            );
        #endregion
    }

    #region Table Creations
    public DbSet<Project> Projects { get; set; }
    #endregion

}