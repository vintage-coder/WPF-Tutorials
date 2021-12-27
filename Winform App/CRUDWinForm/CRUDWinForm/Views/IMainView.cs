using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinForm.Views
{
    public interface IMainView
    {
        event EventHandler MainViewLoadedEventRaised;
        
        event EventHandler EmployeeListBtnClickEventRaised;

        Panel GetUserControlPanel();
        void ShowMainView();
     
    }
}
