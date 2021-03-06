﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using The_Reddit.Entities;
using The_Reddit.Repositories;
using The_Reddit.Viewmodels;
using The_Reddit.Controllers;


namespace The_Reddit
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<TheRedditRepository>();
            services.AddScoped<TheRedditViewModel>();
            services.AddScoped<TheRedditController>();
            services.AddDbContext<TheRedditContext>(options => options.UseSqlServer("Data Source =(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security = True;Connect Timeout = 30;Encrypt = False;TrustServerCertificate = True;ApplicationIntent = ReadWrite;MultiSubnetFailover = False"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
