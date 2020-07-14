using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FairWorks.BLL;
using FairWorks.BLL.Abstract;
using FairWorks.BLL.Services;
using FairWorks.Core;
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
            #region Services
            services.AddSingleton<IUnitofWork, UnitofWork>();
            services.AddSingleton<DbContext, FairWorksDbContext>();
            services.AddTransient<ICompanyService,CompanyService>();
            services.AddTransient<ICatalogFormService, CatalogFormService>();
            services.AddTransient<ICompanyCompanyProfileService, CompanyCompanyProfileService>();
            services.AddTransient<ICompanyProfileService, CompanyProfileService>();
            services.AddTransient<ICompanySectorService, CompanySectorService>();
            services.AddTransient<IContractService, ContractService>();
            services.AddTransient<IContractTypeService, ContractTypeService>();
            services.AddTransient<IFairService, FairService>();
            services.AddTransient<IGuestService, GuestService>();
            services.AddTransient<IInterviewerService, InterviewerService>();
            services.AddTransient<IInterviewFairService, InterviewFairService>();
            services.AddTransient<IInterviewService, InterviewService>();
            services.AddTransient<IJobService, JobService>();
            services.AddTransient<IOfferService, OfferService>();
            services.AddTransient<IParticipantHandBookService, ParticipantHandBookService>();
            services.AddTransient<IPersonelService, PersonelService>();
            services.AddTransient<IPersonelTypeService, PersonelTypeService>();
            services.AddTransient<IProductGroupService, ProductGroupService>();
            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ISalesPersonService, SalesPersonService>();
            services.AddTransient<ISalonService, SalonService>();
            services.AddTransient<ISectorService, SectorService>();
            services.AddTransient<IStandService, StandService>();
            services.AddTransient<IStandTypeService, StandTypeService>();
            #endregion
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

            var context = (FairWorksDbContext)app.ApplicationServices.GetService<DbContext>();
            DataSeeder.SeedPersonelTypes(context);

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
