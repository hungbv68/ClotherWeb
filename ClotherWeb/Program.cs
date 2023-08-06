using ClotherService.DmItemService;
using ClotherService.ProductService;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using New_Clother_Model.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

/* Add ConnectString */
builder.Services.AddDbContext<NewClotherContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Clother")));

/* Add service */

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IDm_Service, Dm_Service>();

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
