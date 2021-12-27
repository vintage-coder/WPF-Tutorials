using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinForm.Presenters.UserControls;
using CRUDWinForm.Views;
using CRUDWinForm.Views.UserControls;

namespace CRUDWinForm.Presenters
{
    public class MainPresenter:IMainPresenter
    {
        IMainView _mainView;
        Panel _userControlPanel;
        private IEmployeeListPrsenter _employeeListPresenter;
        //private IEmployeeDetailPresenter _employeeDetailPresenter;
        private List<UserControl> _userControList;


        public IMainView GetMainView() { return _mainView; }
        public void SetMainView(IMainView mainView) { _mainView = mainView; }

        public MainPresenter()
        {
            
        }

        public MainPresenter(IMainView mainView, IEmployeeListPrsenter employeeListPresenter )
        {
            _mainView = mainView;
            _userControlPanel = _mainView.GetUserControlPanel();
            _employeeListPresenter = employeeListPresenter;
            //_employeeDetailPresenter = employeeDetailPresenter;
            SubscribeToEventsSetup();
        }

        public void SubscribeToEventsSetup()
        {
            _mainView.EmployeeListBtnClickEventRaised += new EventHandler(OnEmployeeListBtnClickEventRaised);

            _mainView.MainViewLoadedEventRaised += new EventHandler(OnMainViewLoadedEventRaised);

        }

        public void OnEmployeeListBtnClickEventRaised(object sender, EventArgs e)
        {
            SetupEmployeeListInPanel();
        }

        public void OnMainViewLoadedEventRaised(object sender, EventArgs e)
        {
            _userControList = new List<UserControl>();
            _userControList.Add((UserControl)_employeeListPresenter.GetEmployeeListViewUC());


            

            AssignUserControlToMainViewPanel((BaseUserControlUC)_employeeListPresenter.GetEmployeeListViewUC());


            //SetUserControlVisibleInPanel((UserControl)_employeeListPresenter.GetEmployeeListViewUC());


        


            //_employeeListPresenter.GetEmployeeListViewUC();

        }

        private void AssignUserControlToMainViewPanel(BaseUserControlUC baseUserControl)
        {
            baseUserControl.SetParentSizeLocationAnchor(_userControlPanel);
        }

        private void SetupEmployeeListInPanel()
        {
            _employeeListPresenter.LoadAllEmployeeFromDbToGrid();
            //SetUserControlVisibleInPanel((UserControl)_employeeListPresenter.GetEmployeeListViewUC());
        }


        private void SetUserControlVisibleInPanel(UserControl userControl)
        {
            foreach (UserControl uc in _userControList)
            {
                if (uc.Name == userControl.Name)
                {
                    userControl.Visible = true;
                }
                else uc.Visible = false;
            }
        }
    }
}
