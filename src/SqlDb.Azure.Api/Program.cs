using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddHealthChecks()
    .AddSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")!);

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();

app.MapHealthChecks("/health/ready");
app.MapHealthChecks("/health/live", new HealthCheckOptions { Predicate = _ => false });

app.Run();
