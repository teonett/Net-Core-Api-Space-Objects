using System;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.OpenApi.Models;
using NetCoreSpaceApi.Data;
using NetCoreSpaceApi.Data.Interfaces;
using NetCoreSpaceApi.Repositories;
using NetCoreSpaceApi.Repositories.Interfaces;
using NetCoreSpaceApi.Services;
using NetCoreSpaceApi.Services.Interfaces;

namespace NetCoreSpaceApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Api Exemplo Swagger",
                    Version = "v1"
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);

                c.IncludeXmlComments(xmlPath);
            });

            string connectionString = "Data Source=spaceObjects.db";
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlite(connectionString);
            });

            services.AddTransient<IPlanetRepository, PlanetRepository>();
            services.AddTransient<ICometRepository, CometRepository>();
            services.AddTransient<IConstelationRepository, ConstelationRepository>();

            services.AddTransient<IDataServices, DataServices>();

            services.AddTransient<IPlanetService, PlanetService>();
            services.AddTransient<ICometService, CometService>();
            services.AddTransient<IConstelationService, ConstelationService>();

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Exemplo Swagger - v1");
            });

            serviceProvider.GetService<IDataServices>().StartDB();
        }
    }
}
