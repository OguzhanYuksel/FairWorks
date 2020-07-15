using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FairWorks.WebUI.Clients.Abstract;
using FairWorks.WebUI.Clients.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FairWorks.WebUI
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
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();

            #region HttpClients
            services.AddHttpClient<IPersonelClient, PersonelClient>(client =>
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            services.AddHttpClient<IInterviewClient, InterviewClient>(client =>
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            services.AddHttpClient<ISectorClient, SectorClient>(client =>
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            services.AddHttpClient<ICompanyClient, CompanyClient>(client =>
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            services.AddHttpClient<IFairClient, FairClient>(client =>
            {
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
            #endregion

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
