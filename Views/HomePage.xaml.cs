using System.ComponentModel;

namespace TestAnalyserMaui.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
       
        public HomePage()
        {
            InitializeComponent();
        }

        private async void ImageButton_OnClicked(object sender, EventArgs e)
        {
            /*await CameraButton.ScaleTo(0.9, 125);
            await CameraButton.TranslateTo(0, -5, 125);
            
            await CameraButton.ScaleTo(1, 125);
            await CameraButton.TranslateTo(0, 5, 125);*/
        }

        private void BindableObject_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
           
        }
    }
}