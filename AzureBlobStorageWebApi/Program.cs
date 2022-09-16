using AzureBlobStorage.WebApi.Common;
using AzureBlobStorage.WebApi.Repository;
using AzureBlobStorage.WebApi.Services;
using Serilog;

StaticLogger.EnsureInitialized();
Log.Information("Azure Storage API Booting Up...");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add Serilog
    builder.Host.UseSerilog((_, config) =>
    {
        config.WriteTo.Console()
        .WriteTo.Seq(serverUrl: "http://seq:5341")
        .ReadFrom.Configuration(builder.Configuration);
    });

    
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    // Add Azure Repository Service
    builder.Services.AddTransient<IAzureStorage, AzureStorage>();
    Log.Information("Services has been successfully added...");

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
    Log.Information("API is now ready to serve files to and from Azure Cloud Storage...");
}
catch (Exception ex) when (!ex.GetType().Name.Equals("StopTheHostException", StringComparison.Ordinal))
{
    StaticLogger.EnsureInitialized();
    Log.Fatal(ex, "Unhandled Exception");
}
finally
{
    StaticLogger.EnsureInitialized();
    Log.Information("Azure Storage API Shutting Down...");
    Log.CloseAndFlush();
}