using System.ComponentModel;
using System.Runtime.CompilerServices;
using XCalendar.Core.Interfaces;

namespace TestAnalyserMaui.Models
{
    public abstract class BaseObservableModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }
}