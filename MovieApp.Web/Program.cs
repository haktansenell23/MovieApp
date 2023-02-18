using Microsoft.EntityFrameworkCore;
using MovieApp.Repository;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



// Add to DbContext and determine for migration assembly way 
builder.Services.AddDbContext<MovieAppDbContext>(
    x=>x.UseSqlServer(builder.Configuration.GetConnectionString("MsSqlConnectionString"),option=>
    option.MigrationsAssembly(Assembly.GetAssembly(typeof(MovieAppDbContext)).GetName().Name)));










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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
