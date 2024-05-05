using Serilog;
using WebArg.CurrencyRates.WebAPI.Extensions;
using WebArg.CurrencyRates.WebAPI.Middlewares;

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
builder.Services.AddWebServices();

var app = builder.Build();

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