using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Accés_Distant.ViewModel;

namespace Accés_Distant.View
{
    /// <summary>
    /// Logique d'interaction pour connexion.xaml
    /// </summary>
    public partial class ConnexionWS : Page
    {
      
        public ConnexionWS()
        {
            ConexionViewModel conexionViewModel = new ConexionViewModel();
            this.DataContext = conexionViewModel;
            InitializeComponent();
        }
    }
}
