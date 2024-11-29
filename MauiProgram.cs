using DonateSomething.Maui.Services;
using DonateSomething.Maui.ViewModels;
using Microsoft.Extensions.Logging;

namespace DonateSomething.Maui
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
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<OrganizationService>();
            builder.Services.AddSingleton<OrganizationListViewModel>();
            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}
