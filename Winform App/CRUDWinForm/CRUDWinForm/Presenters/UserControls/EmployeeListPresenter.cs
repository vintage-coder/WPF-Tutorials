using CRUDWinForm.Views.UserControls;
using ServiceLayer.EmployeeServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinForm.Presenters.UserControls
{
    public class EmployeeListPresenter : IEmployeeListPrsenter
    {

        IEmployeeListViewUC _employeeListViewUC;
        IEmployeeServices _employeeServices;


        BindingSource _employeeListBindingSource;

        public EmployeeListPresenter(IEmployeeListViewUC employeeListViewUC, IEmployeeServices employeeServices)
        {
            _employeeListViewUC = employeeListViewUC;
            _employeeServices = employeeServices;

            _employeeListViewUC.ShowView();
        }

        public IEmployeeListViewUC GetEmployeeListViewUC()
        {
            return _employeeListViewUC;
        }

        public void LoadAllEmployeeFromDbToGrid()
        {
            GetAllEmployeeListForGridLoad();
        }



        public void GetAllEmployeeListForGridLoad()
        {
            _employeeListBindingSource = new BindingSource();

            _employeeServices.BuildDatasourceForAllEmployeeList(_employeeListBindingSource);

            Dictionary<string, string> headingsDictionary = new Dictionary<string, string>();
            Dictionary<string, float> gridColumnWidthsDictionary = new Dictionary<string, float>();

            SetEmployeeViewGridHeadings(headingsDictionary);

            SetEmployeeViewGridColumnWidths(gridColumnWidthsDictionary);

            const int rowHeight = 75;

            LoadAllEmployeeListToGrid(_employeeListBindingSource, headingsDictionary, gridColumnWidthsDictionary, rowHeight);
        }

        private void LoadAllEmployeeListToGrid(BindingSource bindingSource, Dictionary<string, string> headingsDictionary,
                                         Dictionary<string, float> gridColumnWidthsDictionary, int rowHeight)
        {
            _employeeListViewUC.LoadAllEmployeeListToGrid(bindingSource, headingsDictionary, gridColumnWidthsDictionary, rowHeight);
        }

        private void SetEmployeeViewGridColumnWidths(Dictionary<string, float> gridColumnWidthsDictionary)
        {
            gridColumnWidthsDictionary["EMPID"] = (float)(.20);
            gridColumnWidthsDictionary["FirstName"] = (float)(.25);
            gridColumnWidthsDictionary["LastName"] = (float)(.25);
            gridColumnWidthsDictionary["EmailId"] = (float)(.25);
            gridColumnWidthsDictionary["IsMember"] = (float)(.25);
            gridColumnWidthsDictionary["Status"] = (float)(.25);
            gridColumnWidthsDictionary["DOB"] = (float)(.25);
            gridColumnWidthsDictionary["Role"] = (float)(.25);

        }

        private void SetEmployeeViewGridHeadings(Dictionary<string, string> headingsDictionary)
        {
            headingsDictionary["EMPID"] = "Emp id";
            headingsDictionary["FirstName"] = "First Name";
            headingsDictionary["LastName"] = "Last Name";
            headingsDictionary["EmailId"] = "Email ID";
            headingsDictionary["IsMember"] = "Is Member";
            headingsDictionary["Status"] = "status";
            headingsDictionary["DOB"] = "Date of Birth";
            headingsDictionary["Role"] = "Role";


        }

    }
}
