using CoreArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CoreArchitecture.Domain
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Note> Notes { get; set; }

    }

}
