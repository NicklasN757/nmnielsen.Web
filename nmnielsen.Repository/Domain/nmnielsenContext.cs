using Microsoft.EntityFrameworkCore;
using nmnielsen.Repository.Entities;

namespace nmnielsen.Repository.Domain;
public class nmnielsenContext : DbContext
{
    public nmnielsenContext() { }
    public nmnielsenContext(DbContextOptions<nmnielsenContext> optionsBuilder) : base(optionsBuilder) { }

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

        #region User table
        //Keys And Relations
        modelBuilder.Entity<User>().HasKey(u => u.Id);

        //Properties

        //Data
        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Username = "test", Password = "test" }
            );
        #endregion

        #region UserInformation table
        //Keys And Relations
        modelBuilder.Entity<UserInformation>().HasKey(ui => ui.Id);
        modelBuilder.Entity<UserInformation>().HasOne(ui => ui.User).WithOne(u => u.UserInformation).HasForeignKey<UserInformation>(ui => ui.Id);

        //Properties
        modelBuilder.Entity<UserInformation>().Property(ui => ui.CreatedDate).HasDefaultValueSql("GetDate()");
        modelBuilder.Entity<UserInformation>().Property(ui => ui.IsAdmin).HasDefaultValue(false);

        //Data
        modelBuilder.Entity<UserInformation>().HasData(
            new UserInformation { Id = 1, FirstName = "Nicklas", LastName = "Nielsen", IsAdmin = true }
            );
        #endregion
    }

    #region Table Creations
    public DbSet<Project> Projects { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserInformation> UserInformation { get; set; }
    #endregion

}