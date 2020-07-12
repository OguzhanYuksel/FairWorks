using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FairWorks.BLL;
using FairWorks.BLL.Services;
using FairWorks.DAL;
using FairWorks.DAL.Data.UnitOfWork;
using FairWorks.Mapping.ConfigProfile;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace FairWorks.WebAPI
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
            services.AddSingleton<IUnitofWork, UnitofWork>();
            services.AddSingleton<DbContext, FairWorksDbContext>();
            services.AddTransient<ICompanyService,CompanyService>();
            MapperFactory.RegisterMappers();
            services.AddSwaggerGen(z => z.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo { Title = "FairWorksAPI", Version = "V1" }));
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(z =>
                    z.SwaggerEndpoint("/swagger/v1/swagger.json", "FairWorksAPI")
            );

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
