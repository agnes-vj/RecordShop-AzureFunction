using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using RecordShopFunctionApp.Services;

[assembly: FunctionsStartup(typeof(RecordShopFunctionApp.Startup))]

namespace RecordShopFunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<IAlbumsService, AlbumsService>();
        }
    }
}
