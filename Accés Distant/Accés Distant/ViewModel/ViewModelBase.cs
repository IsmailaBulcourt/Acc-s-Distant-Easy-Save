using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Accés_Distant.Model;

namespace Accés_Distant.ViewModel
{
    public class ViewModelBase
    {
        public static ObservableCollection<SaveToDisplay> ListSave { get; set; }
    }
}
