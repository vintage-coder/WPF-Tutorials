using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDWinForm.Views;

namespace CRUDWinForm.Presenters
{
    interface IMainPresenter
    {
        void OnEmployeeListBtnClickEventRaised(object sender, EventArgs e);
        void OnMainViewLoadedEventRaised(object sender, System.EventArgs e);
        IMainView GetMainView();
        void SetMainView(IMainView mainView);
    }
}
