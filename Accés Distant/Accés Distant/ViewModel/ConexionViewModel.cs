using Newtonsoft.Json;
using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Accés_Distant.Model;
using System.Collections.ObjectModel;

namespace Accés_Distant.ViewModel
{
    public class ConexionViewModel : ViewModelBase
    {
        public DelegateCommand CreateConnexionCommand { get; set; }
        public string AddressIP { get; set; }
        public string Port { get; set; }
       
        public ConexionViewModel()
        {
            CreateConnexionCommand = new DelegateCommand(CreateConnexionStart);
        }

        public void CreateConnexionStart()
        {
            Client client = new Client();
            client.Connection(AddressIP, Convert.ToInt32(Port));
            var data = client.ListenConnection();
            var tempListSave = new ObservableCollection<SaveToDisplay>(JsonConvert.DeserializeObject<List<SaveToDisplay>>(data));
            foreach (var item in tempListSave)
            {
                ListSave.Add(item);
            }
        }
    }
}
