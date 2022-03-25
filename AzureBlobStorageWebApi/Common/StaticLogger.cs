using Serilog;

namespace AzureBlobStorage.WebApi.Common
{
    public class StaticLogger
    {
        public static void EnsureInitialized()
        {
            if (Log.Logger is not Serilog.Core.Logger)
            {
                Log.Logger = new LoggerConfiguration()
                    .Enrich.FromLogContext()
                    .WriteTo.Console()
                    .CreateLogger();
            }
        }
    }
}
