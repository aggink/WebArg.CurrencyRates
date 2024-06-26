using Serilog;
using WebArg.CurrencyRates.Quartz.Extensions;
using WebArg.CurrencyRates.Quartz.Middlewares;
using WebArg.CurrencyRates.Storage.MS_SQL.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDataContext(builder.Configuration);
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

builder.Host.UseSerilog((context, Configuration) =>
   Configuration.ReadFrom.Configuration(context.Configuration));

builder.Services.AddFluentValidationSetup(typeof(Program));
builder.Services.AddSwaggerSetup();
builder.Services.AddQuartzServices();
builder.Services.RegisterQuartzServices(builder.Configuration);

var app = builder.Build();

using var scope = app.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
var migrationService = scope.ServiceProvider.GetRequiredService<MigrationService>();
migrationService.ApplyMigrations();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseSerilogRequestLogging();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Crypto");
        options.EnableDeepLinking();
    });
}

app.UseMiddleware<ExceptionMiddleware>();

app.UseRouting();

app.MapControllers();

app.Run();

public partial class Program { }