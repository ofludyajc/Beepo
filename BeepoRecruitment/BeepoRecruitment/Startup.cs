using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using BeepoRecruitment.Services.CandidateService;
using BeepoRecruitment.BLL.CandidateBLL;
using BeepoRecruitment.CL.CandidateCL;
using BeepoRecruitment.Services.BeepoEmployeeService;
using BeepoRecruitment.BLL.BeepoEmployeeBLL;
using BeepoRecruitment.CL.BeepoEmployeeCL;
using AutoMapper;

namespace BeepoRecruitment
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
            services.AddControllersWithViews();
            services.AddControllers();
            services.AddCors();
            services.AddMvc();
            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "BeepoRecruitment API", Version = "v1" });
            });

            services.AddScoped<ICandidateService, CandidateService>();
            services.AddSingleton<ICandidateBLL, CandidateBLL>();
            services.AddSingleton<ICandidateCL, CandidateCL>();

            services.AddScoped<IBeepoEmployeeService, BeepoEmployeeService>();
            services.AddSingleton<IBeepoEmployeeBLL, BeepoEmployeeBLL>();
            services.AddSingleton<IBeepoEmployeeCL, BeepoEmployeeCL>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "BeepoRecruitment API");
                c.RoutePrefix = string.Empty;
            });

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
