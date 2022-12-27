using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Sharpnado.Tabs;

namespace TestAnalyserMaui;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.UseSharpnadoTabs(loggerEnable: false)
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Vasek.ttf", "Vasek");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
