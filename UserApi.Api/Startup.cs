using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace UserApi.Api
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.OpenApi.Models;
    using System.IO;
    using System.Reflection;
    using UserApi.Business.Abstract;
    using UserApi.Business.Concreate;
    using UserApi.DAL.Abstract;
    using UserApi.DAL.Concreate;
    using UserApi.DAL.Context;

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

            services.AddDbContext<UserContext>(t0 => t0.UseSqlServer(Configuration.GetConnectionString("ConString")));
            services.AddTransient<IUserDal, UserDal>();
            services.AddTransient<IUserBusiness, UserBusiness>();
            services.AddCors();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Version = "v1", Title = ".NET Core Swagger" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(t0 => t0
            .AllowAnyHeader().
            AllowAnyMethod().
            AllowAnyOrigin());

            app.UseAuthorization();
            app.UseSwagger();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.DocumentTitle = "Swagger API doküman baþlýðý";
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "Swagger API baþlýðý");
            });
        }
    }
}
