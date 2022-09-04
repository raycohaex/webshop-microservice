using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => {
    options.AddPolicy("CORSPolicy", builder => builder.AllowAnyMethod().AllowAnyHeader().AllowCredentials().SetIsOriginAllowed((hosts) => true));
});

builder.Services.AddControllers();

builder.Configuration.AddJsonFile(builder.Configuration.GetValue<string>("Gateway:config"), optional: false, reloadOnChange: true);

builder.Services.AddOcelot(builder.Configuration);

var app = builder.Build();

app.UseCors("CORSPolicy");
app.UseAuthorization();
app.MapControllers();
await app.UseOcelot();

app.MapGet("/", () => "Hello World!");

app.Run();
