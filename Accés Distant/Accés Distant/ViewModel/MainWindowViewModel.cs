using System;
using System.Collections.Generic;
using System.Text;

namespace Accés_Distant.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel(MainWindow mainWindow)
        {
            ListSave = new System.Collections.ObjectModel.ObservableCollection<Model.SaveToDisplay>();
        }
    }
}
