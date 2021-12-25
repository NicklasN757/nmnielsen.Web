using Microsoft.EntityFrameworkCore;
using nmnielsen.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nmnielsen.Repository.Domain
{
    public class nmnielsenContext : DbContext
    {
        public nmnielsenContext() { }

        public nmnielsenContext(DbContextOptions<nmnielsenContext> optionsBuilder) : base(optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Project table
            //Keys And Relations
            //Properties
            //Data
            #endregion

            #region User table
            //Keys And Relations
            //Properties
            //Data
            #endregion

            #region UserInformation table
            //Keys And Relations
            //Properties
            //Data
            #endregion
        }

        #region Table Creations
        public DbSet<Project> Projects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserInformation> UserInformation { get; set; }
        #endregion
    }
}