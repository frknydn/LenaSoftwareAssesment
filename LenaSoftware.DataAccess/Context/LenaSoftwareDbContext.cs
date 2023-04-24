using LenaSoftware.Entities.DbSets;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaSoftware.DataAccess.Context
{
    public class LenaSoftwareDbContext : DbContext
    {
        public LenaSoftwareDbContext(DbContextOptions<LenaSoftwareDbContext> options) : base(options) { }
        public DbSet<Form> Forms { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<User>().HasData(
                new User
                {                    
                    UserID=1,
                    FirstName = "Furkan",
                    LastName = "Aydın",
                    Email = "furkan.aydin@email.com",
                    Password = "furkan",
                    PhoneNumber = "05317029136"
                });

            modelBuilder.Entity<Form>().HasData(new Form
            {
                FormID = 1,
                FormName = "Test Form",
                Description = " ",
                Name = "Furkan",
                Surname = "Aydın",
                Age = 30,
                CreatedBy = 1,
                CreatedTime = DateTime.Now,
                UserID = 1

            });
        }
    }
}
