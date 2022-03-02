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
            new Project { Id = 1, Name = "nmnielsen.dk website", Description = "This project is the site you see this on" }
            );
        #endregion
    }

    #region Table Creations
    public DbSet<Project> Projects { get; set; }
    #endregion

}