using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreArchitecture.TestOne.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoreArchitecture.TestOne.Data
{
    public class CoreArchitectureTestOneContext : IdentityDbContext<CoreArchitectureTestOneUser>
    {
        public CoreArchitectureTestOneContext(DbContextOptions<CoreArchitectureTestOneContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
