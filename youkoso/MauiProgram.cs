using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using youkoso.ViewModels;
using youkoso.Views;

namespace youkoso
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
.UseMauiApp<App>()
.UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            builder.UseMauiCommunityToolkitMediaElement(); // ここにメソッドを追加

            return builder.Build();
        }
    }
}