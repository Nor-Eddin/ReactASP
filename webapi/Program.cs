using Microsoft.EntityFrameworkCore;
using webapi.DataPostgresSql.DataBase;
using webapi.DataPostgresSql.DataLayer;
using webapi.Infrastructures;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ProductDbContext>(option =>
{
    option.UseNpgsql(builder.Configuration.GetConnectionString("ProductContext"));
});
builder.Services.AddScoped<IProductDataLayer, PostgreSQLDataLayer>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



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
