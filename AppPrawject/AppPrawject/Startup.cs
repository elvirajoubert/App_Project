using AppPrawject.Data.Context;
using AppPrawject.Data.Implementation.SqlServer;
using AppPrawject.Data.Interfaces;
using AppPrawject.Domain.Model;
using AppPrawject.Service.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AppPrawject
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });


            //Add DbContext as a Service
            services.AddDbContext<AppPrawjectDbContext>();



            //Add Identity as a Service
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<AppPrawjectDbContext>();

            AddServiceImplementation(services);
            AddRepositoryImplementation(services);


            //Match the Interface with implementation wherever we have dependency in a constructor


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }


        private void AddRepositoryImplementation(IServiceCollection services)
        {
            services.AddSingleton<IPetRepository, SqlServerPetRepository>();
            services.AddSingleton<IPetBreedRepository, SqlServerPetBreedRepository>();
        }

        private void AddServiceImplementation(IServiceCollection services)
        {
            services.AddSingleton<IPetService, PetService>();
            services.AddSingleton<IPetBreedService, PetBreedService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
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

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
