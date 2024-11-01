using Infrastructure;
using Infrastructure.RepositoryPattern;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Service;
using Service.ServiceClasses;
using Service.ServiceInterfaces;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

TypeAdapterConfig.GlobalSettings.Default.PreserveReference(true);
MapsterConfig.RegisterMapping();

builder.Services.AddMvc();
builder.Services.AddControllers();
builder.Services.AddRazorPages();

builder.Services.AddIdentity<User, Role>().AddEntityFrameworkStores<OnlineTicketReservationDbContext>().AddDefaultTokenProviders();
builder.Services.AddDbContext<DbContext, OnlineTicketReservationDbContext>();
builder.Services.AddScoped<ClaimsPrincipal>();
builder.Services.ConfigureApplicationCookie(option =>
{
    option.LoginPath = "/Identity/Account/Login";
});

builder.Services.AddScoped(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProvinceService, ProvinceService>();

builder.Services.AddAuthentication();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
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

app.Run();