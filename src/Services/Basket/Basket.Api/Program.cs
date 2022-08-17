using Basket.Api.Repositories;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


ConfigurationManager Configuration = builder.Configuration;

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = Configuration.GetValue<string>("CacheSettings:ConnectionString");
});
builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Webshop Microservice Basket API", Version = "v1" });
}
);
builder.Services.AddScoped<IBasketRepository, BasketRepository>();

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
