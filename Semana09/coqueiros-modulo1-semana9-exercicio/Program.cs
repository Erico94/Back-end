using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using coqueiros_modulo1_semana9_exercicio.Controllers;
using Microsoft.AspNetCore.Hosting.Server;
using coqueiros_modulo1_semana9_exercicio.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection_string =" Server=DESKTOP-BG5E4QK\\SQLEXPRESS;Database=Mes;Trusted_Connection=True;TrustServerCertificate=True;";
builder.Services.AddDbContext<SemanaContext>(o => o.UseSqlServer(connection_string));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
