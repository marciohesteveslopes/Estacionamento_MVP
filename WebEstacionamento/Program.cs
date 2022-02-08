using Application.Interfaces;
using Application.OpenApp;
using Domain.Interfaces.Generics;
using Domain.Interfaces.InterfaceEstacionamento;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Infrastructure.Repository.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;
var connStr = configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextPool<ContextBase>(
    options => options.UseSqlServer(connStr));

// Add services to the container.
builder.Services.AddSingleton(typeof(IGeneric<>), typeof(GenericsRepository<>));
builder.Services.AddSingleton<IEstacionamento, EstacionamentoRepository>();
builder.Services.AddSingleton<IEstacionamentoApp, EstacionamentoApp>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Estacionamento}/{action=Index}/{id?}");

app.Run();
