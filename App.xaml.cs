using TestAnalyserMaui.Views;

namespace TestAnalyserMaui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		if (Current != null) Current.UserAppTheme = AppTheme.Light;
		MainPage = new MainPage();
	}
}
