var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers()
    .AddDapr();

var app = builder.Build();

app.UseRouting();
app.UseCloudEvents();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();