using Ordering.API;
using Ordering.Application;
using Ordering.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services
    .AddApplicationServices()
    .AddInfrastrucutreServices(builder.Configuration)
    .AddApiServices();

var app = builder.Build();

// Configure http request pipeline.

app.UseApiServices();

app.Run();
