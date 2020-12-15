using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;

namespace Accés_Distant.ViewModel
{
    class SaveViewModel : ViewModelBase
    {
        public DelegateCommand ExecuteWSCommand { get; set; }
        public DelegateCommand PauseWSCommand { get; set; }
        public DelegateCommand StopWSCommand { get; set; }

        public SaveViewModel()
        {
            ExecuteWSCommand = new DelegateCommand(ExecuteWS);
            PauseWSCommand = new DelegateCommand(PauseWs);
            StopWSCommand = new DelegateCommand(StopWs);
        }

        public void ExecuteWS()
        {
            Client.SendExecuteWs();
        }

        public void PauseWs()
        {
            Client.SendPause();
        }

        public void StopWs()
        {
            Client.SendStop();
        }
    }
}
