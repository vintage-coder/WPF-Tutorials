using CRUDWinForm.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWinForm.Presenters.UserControls
{
    public interface IEmployeeListPrsenter
    {

        void GetAllEmployeeListForGridLoad();
        IEmployeeListViewUC GetEmployeeListViewUC();
        void LoadAllEmployeeFromDbToGrid();
    }
}
