﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SSDepartmentCore.Data;
using SSDepartmentCore.Services;
using SSDepartmentCore.Services.Visitors;

namespace Library
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
            // Added framework services.
            services.AddMvc();
            // Adding the Database service
            services.AddSingleton(Configuration);
            services.AddDbContext<DataContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SSDeptConnection")));
            services.AddScoped<IVisitorInfo, VisitorService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // These are MiddleWares
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
