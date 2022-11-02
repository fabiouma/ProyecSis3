using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();



//esto se cambia con la vara de la base de datos

builder.Services.AddDbContext<ProyecSis3.Models.ProyectoSI3Context>(
    options => options.UseSqlServer("data source=DESKTOP-GJPKMKE\\SQLEXPRESS;initial catalog=ProyectoSI3;trusted_connection=true"));
//Hola commit Andrey


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


