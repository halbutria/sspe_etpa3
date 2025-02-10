using SispeServicios.Api.Gateway;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("Ocelot.json", optional: false, reloadOnChange: true);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();