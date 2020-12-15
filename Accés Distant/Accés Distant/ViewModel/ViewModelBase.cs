using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace Accés_Distant.ViewModel
{
    public class ViewModelBase: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
