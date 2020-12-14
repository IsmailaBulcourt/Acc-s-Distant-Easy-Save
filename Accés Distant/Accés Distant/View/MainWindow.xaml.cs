using Accés_Distant.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System;
using System.Diagnostics;
using Accés_Distant.View;

namespace Accés_Distant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsFirstRender = true;
        public MainWindow()
        {
            MainWindowViewModel mainWindowViewModel = new MainWindowViewModel(this);
            InitializeComponent();

            if (IsFirstRender)
            {
              
                TabItem connect = new TabItem();
                connect.Header = "Connexion";
                Frame tabFrameConnect = new Frame();
                ConnexionWS connectionWS = new ConnexionWS();
                tabFrameConnect.Content = connectionWS;
                connect.Content = tabFrameConnect;
                Menu.Items.Add(connect);

                TabItem save = new TabItem();
                save.Header = "Save";
                Frame tabFrameSave = new Frame();
                SaveWS saveWS = new SaveWS();
                tabFrameSave.Content = saveWS;
                save.Content = tabFrameSave;
                Menu.Items.Add(save);
                IsFirstRender = false;
            }
            }
        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
