using Business.Abstracts;
using Business.Concrete;
using DataAccess.Abstracts;
using DataAccess.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Biri senden IBrandService isterse BrandManager ver demek
// Bu sat�r gelince new BrandManager() olu�turur ve bu sayede IBrandService kulland��� yerlerde onu verir
builder.Services.AddSingleton<IBrandService, BrandManager>();

builder.Services.AddSingleton<IBrandDal, BrandDal>();

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
