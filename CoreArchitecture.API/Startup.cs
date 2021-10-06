using CoreArchitecture.Domain;
using CoreArchitecture.Domain.Entities;
using CoreArchitecture.Facade;
using CoreArchitecture.Handlers.Handlers;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System.Collections.Generic;
using System.Reflection;

namespace CoreArchitecture.API
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddScoped<IStudentFacade, StudentFacade>();
            services.AddMemoryCache();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CoreArchitecture.API", Version = "v1" });
            });

            services.AddMediatR(typeof(CreateStudentHandler).GetTypeInfo().Assembly);

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "Test")
                .Options;

            using (var context = new ApplicationDbContext(options))
            {

                var testStudent =
                    new Student
                    {
                        Id = 1,
                        Name = "Samet",
                        Surname = "Uca",
                        Notes =
                            new List<Note>
                            {
                                new Note
                                {
                                    Id = 1,
                                    Note1 = 100,
                                    Note2 = 100,
                                    Note3 = 100,
                                    StudentId = 1
                                }
                            }
                    };
                context.Students.Add(testStudent);
                context.SaveChanges();
            }



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", $"Test{env.EnvironmentName})");
                });
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
