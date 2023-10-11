using Microsoft.EntityFrameworkCore;
using movies.DataAccess;
using movies.DataAccess.Services;
using movies.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//to setup sqlserver
builder.Services.AddDbContext<AppDbContext>(options=>{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
});
//Registering Services
/*
Dependency Injection Types
1. Transcient New service every time requested
2. Scoped     New object for each request
3. Singleton  New object for the etire lifetime of app
*/
builder.Services.AddScoped<IActorsService,ActorsService>();
builder.Services.AddScoped<IProducersService,ProducersService>();


var app = builder.Build();
// AppDbInitializer.Seed(app);

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
