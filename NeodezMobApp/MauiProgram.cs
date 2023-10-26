using Microsoft.Maui.Hosting;

namespace NeodezMobApp;

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
				fonts.AddFont("arialnarrow.ttf", "arialNarrow");
				fonts.AddFont("arialmt.ttf", "Arial");
			});
        

        return builder.Build();
	}
}
