using System;
using CoreArchitecture.TestOne.Areas.Identity.Data;
using CoreArchitecture.TestOne.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(CoreArchitecture.TestOne.Areas.Identity.IdentityHostingStartup))]
namespace CoreArchitecture.TestOne.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<CoreArchitectureTestOneContext>(opt =>
                    opt.UseSqlServer(context.Configuration.GetConnectionString("DefaultConnection")));
                services.AddDefaultIdentity<CoreArchitectureTestOneUser>(opt =>
                        opt.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<CoreArchitectureTestOneContext>();
            });
        }
    }
}