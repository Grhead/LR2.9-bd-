using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace LR2._9_bd_
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Taskk> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().HasKey(u => u.Userid);
        //    modelBuilder.Entity<Taskk>().HasKey(u => u.Taskid);
        //    modelBuilder.Entity<Status>().HasKey(u => u.Statusid);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=localdb;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                        .HasMany(task => task.Tasks)
                        .WithOne(con => con.Users);

            modelBuilder.Entity<Taskk>()
                        .HasMany(task => task.CreatorID)
                        .HasForeignKey(con => con.Users);

            base.OnModelCreating(modelBuilder);
        }
    }
}
