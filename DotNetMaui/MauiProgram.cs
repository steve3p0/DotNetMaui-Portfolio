using DotNetMaui.Services;
using DotNetMaui.Shared.Pages;
using DotNetMaui.Shared.Services;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace DotNetMaui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // Add device-specific services used by the DotNetMaui.Shared project
            builder.Services.AddSingleton<IFormFactor, FormFactor>();

            // Register HttpClient for dependency injection
            builder.Services.AddHttpClient();

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
