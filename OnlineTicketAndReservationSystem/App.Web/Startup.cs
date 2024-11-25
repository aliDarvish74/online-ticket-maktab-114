using Infrastructure;
using Infrastructure.RepositoryPattern;
using Mapster;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Model.Entities;
using Serilog;
using Service;
using Service.ServiceClasses;
using Service.ServiceInterfaces;
using System.Security.Claims;

namespace App.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.Debug()
                        .Enrich.FromLogContext()
                        .WriteTo.Console()
                        .WriteTo.Seq("http://localhost:5341") // Replace with your Seq server URL
                        .CreateLogger();

            TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
            MapsterConfig.RegisterMapping();

            services.AddMvc();
            services.AddControllers();
            services.AddRazorPages();

            services.AddIdentity<User, Role>().AddEntityFrameworkStores<OnlineTicketReservationDbContext>().AddDefaultTokenProviders();
            services.AddDbContext<DbContext, OnlineTicketReservationDbContext>();
            services.AddScoped<ClaimsPrincipal>();
            services.ConfigureApplicationCookie(option =>
            {
                option.LoginPath = "/Identity/Account/Login";
            });

            services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IBlobService, BlobService>();
            services.AddScoped<IProvinceService, ProvinceService>();

            services.AddAuthentication();
            //services.AddAuthorization();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Configure the HTTP request pipeline.
            if (!env.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
