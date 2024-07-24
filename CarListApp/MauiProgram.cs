using CarListApp.Services;
using CarListApp.ViewModels;
using CarListApp.Views;
using Microsoft.Extensions.Logging;

namespace CarListApp
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif


            builder.Services.AddSingleton<CarService>();
            builder.Services.AddSingleton<CarsViewModel>();
            builder.Services.AddTransient<CarDetailsViewModel>();
          
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<CarDetailsPage>();
            return builder.Build();
        }
    }
}
