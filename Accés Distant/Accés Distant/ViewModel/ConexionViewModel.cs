using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Windows;

namespace Accés_Distant.ViewModel
{
    public class ConexionViewModel: ViewModelBase
    {
        public string Ad { get; set; } = "";
        public DelegateCommand CreateConnexionCommand { get; set; }
       
        public ConexionViewModel()
        {
            CreateConnexionCommand = new DelegateCommand(CreateConnexionStart);
        }

        public void CreateConnexionStart()
        {
            MessageBox.Show("tentative de connexion");
            Client.StartClient(IPAddress.Parse(Ad));
            

        }
    }

}
