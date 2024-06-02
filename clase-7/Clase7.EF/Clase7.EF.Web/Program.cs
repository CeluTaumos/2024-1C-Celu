using Microsoft.AspNetCore.Mvc;
using Clase7.EF.Data.Entidades;
using Clase7.EF.Logica;
using Clase7.EF.Test.Logica;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Pw32cIslaTesoroContext>();
builder.Services.AddScoped<UbicacionServicio, UbicacionServicio>();
builder.Services.AddScoped<ITesoroServicio, TesoroServicio>();
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
