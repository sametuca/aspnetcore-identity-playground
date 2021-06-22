using System;
using System.Collections.Generic;
using System.Text;
using CoreArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreArchitecture.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
          
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public void AddTestData(ApplicationDbContext context)
        {
            var testStudent = 
                new Student
            {
                Id = Convert.ToInt32(Guid.NewGuid()),
                Name = "Samet",
                Surname = "Uca",
                Notes = 
                    new List<Note>
                    {
                        new Note
                        {
                            Id = Convert.ToInt32(Guid.NewGuid()),
                            Note1 = 100,
                            Note2 = 100,
                            Note3 = 100
                        }
                }
            };
            context.Students.Add(testStudent);
            context.SaveChanges();
        }
    }
    
}
