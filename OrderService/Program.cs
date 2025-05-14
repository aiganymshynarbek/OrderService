using OrderService.Data;
using Microsoft.EntityFrameworkCore;
using OrderService.Services;
using OrderService.Mappings;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Register PostgreSQL DbContext
builder.Services.AddDbContext<OrderDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//AutoMapper
builder.Services.AddAutoMapper(typeof(OrderProfile));

builder.Services.AddScoped<OrderService.Services.IOrderService, OrderService.Services.OrderService>();



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
