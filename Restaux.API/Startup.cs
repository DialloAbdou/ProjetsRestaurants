using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Restaux.Core;
using Restaux.Core.Repositories;
using Restaux.Data;
using Restaux.Data.MongoDb.Repositories;
using Restaux.Data.MongoDb.Setting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaux.API
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
            // =======Configuration SQLServer=====

            services.AddDbContext<RestoDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("RestoConexion"), x => x.MigrationsAssembly("Restaux.Data")));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            //=====Configuration MongoDb===
            services.Configure<Settings>(
                options =>
                {
                    options.ConnectionString = Configuration.GetValue<string>("MongoDB:ConnectionString");
                    options.DataBase = Configuration.GetValue<string>("MongoDB:Database");
                });

            //===Connexion De MongoDb=====
            services.AddSingleton<IMongoClient, MongoClient>(_ => new MongoClient(Configuration.GetValue<string>("MongoDB:ConnectionString")));

            //==Injection Repo====
            services.AddScoped<IComposerRepository, ComposerRepository>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
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
