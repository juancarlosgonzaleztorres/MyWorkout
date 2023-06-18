using Amazon.DynamoDBv2;
using Core;
using DotNetCoreRepository2.Excercise;
using DotNetCoreRepository2.MockRepository;
using DotNetCoreRepository2.Models;
using Generic;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository;

namespace ExcerciseApi
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
            //Test Excercise API with Entity Framework
            //services.AddSingleton<DbContext, EntityFrameworkSQLiteExcerciseContext>();
            //services.AddSingleton<ICRUD<Core.Excercise>, ExcerciseRepository>();
            //services.AddDbContext<MyWorkoutContext>(
            //        options => options.UseSqlServer("Data Source=corsair;Initial Catalog=MyWorkout;Integrated Security=True"));
            services.AddSingleton<ICRUD<Core.Excercise>, EFExcerciseRepository>();
            services.AddSingleton<DbContext, MyWorkoutContext>();

            //Test Excercise API in isolation
            //services.AddSingleton<ICRUD<Core.Excercise>, ExcerciseRepositoryDummyData>();
            //services.AddSingleton<ICRUD<Excercise>, ExcerciseRepository>();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddAWSService<IAmazonDynamoDB>();
            //services.AddAWSService<IAmazonDynamoDB>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsEnvironment("local"))
            {
                app.UseDeveloperExceptionPage();
            }
            else if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for 
                // production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
