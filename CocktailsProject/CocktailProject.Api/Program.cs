using System.Reflection;
using CocktailProject.Implementation.DI;
using CocktailProject.Implementation;
using CocktailProject.Implementation.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContextFactory<CocktailsContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("CocktailsContext")));

builder.Services.AddMediatR(cfg =>
     cfg.RegisterServicesFromAssembly(typeof(Implementation).Assembly));

builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();