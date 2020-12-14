using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Accés_Distant.ViewModel
{
    class ConexionViewModel
    {
        public DelegateCommand CreateConnexionCommand { get; set; }
       
        public void CreateConnexion()
        {
            CreateConnexionCommand = new DelegateCommand(CreateConnexionStart);
        }

        public void CreateConnexionStart()
        {

        }
    }

}
