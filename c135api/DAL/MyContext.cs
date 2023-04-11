using c135api.Entities;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection.Metadata;
using System.Security;

namespace c135api.DAL
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public DbSet<Blok> Bloks { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Permission> Permissions { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Citizen>().HasOne(m => m.Father).WithOne();
            modelBuilder.Entity<Citizen>().HasOne(m => m.Mother).WithOne();

            modelBuilder.Entity<Blok>().HasData(
                new Blok()
                {
                    Id = 1,
                    Number = "1"
                },
                new Blok()
                {
                    Id = 2,
                    Number = "2"
                }
                );

            modelBuilder.Entity<Permission>().HasData(
                new Permission()
                {
                    Id = 1,
                    Name = "add",
                    Key = "add"
                },
                new Permission()
                {
                    Id = 2,
                    Name = "hesabat",
                    Key = "reprot"
                },
                new Permission()
                {
                    Id = 3,
                    Name = "view",
                    Key = "view"
                }
                );


            modelBuilder.Entity<Blok>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Floor>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Role>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<User>().HasQueryFilter(m => !m.IsDeleted);
            modelBuilder.Entity<Permission>().HasQueryFilter(m => !m.IsDeleted);

            base.OnModelCreating(modelBuilder);
        }

    }
}
