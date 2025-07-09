using Microsoft.AspNetCore.Builder;
var builder = WebApplication.CreateBuilder(args);

SpaceAPI.Host.WebApplicationBuilder.ConfigureServices(builder.Services, builder.Configuration);

var app = builder.Build();

SpaceAPI.Host.WebApplicationBuilder.Configure(app, app.Environment);


app.Run();