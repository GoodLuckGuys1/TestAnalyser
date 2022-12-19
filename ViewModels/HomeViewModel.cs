using System.Globalization;
using AnalyserTestMobileApp.ViewModels;

namespace TestAnalyserMaui.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {

        public CultureInfo Culture => new CultureInfo("ru-RU");
        public HomeViewModel()
        {
            
        }
    }
}