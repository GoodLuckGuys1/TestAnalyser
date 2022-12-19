using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;
using TabbedPage = Microsoft.Maui.Controls.TabbedPage;

namespace TestAnalyserMaui.Views
{
	public partial class MainPage : TabbedPage
	{
		public MainPage()
		{
			InitializeComponent();
			On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
		}
	}
}
