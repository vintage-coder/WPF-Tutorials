using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinForm.Views.UserControls
{
    public interface IEmployeeListViewUC
    {
        event EventHandler DisplayAllEmployeeBtnClickEventRaised;
        event EventHandler LoadOfAllEmployeeIntoGridCompletedEventRaised;
        event EventHandler EmployeeListViewUCLoadEventRaised;

        void LoadAllEmployeeListToGrid(BindingSource _employeeListBindingSource, Dictionary<string, string> headingsDictionary, Dictionary<string, float> gridColumnWidthsDictionary, int rowHeight);
        void RaisEventDisplayAllEmployeeBtnClicked(EventArgs e);
        void SetGridColumnWidths(Dictionary<string, float> gridColumnWidthsDictionary);
        void SetGridHeaderText(Dictionary<string, string> headingsDictionary);
        void ShowView();

       
    }
}
