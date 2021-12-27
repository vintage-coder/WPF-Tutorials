
using CommonComponents;
using CRUDWinForm.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDWinForm
{
    public partial class MainView : Form,IMainView
    {

        public event EventHandler MainViewLoadedEventRaised;
       
        public event EventHandler EmployeeListBtnClickEventRaised;

        private Panel _userControlPanelOrigValues = null;

        public MainView()
        {
            InitializeComponent();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            EventHelpers.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: EmployeeListBtnClickEventRaised, eventArgs: e);
        }


        public void ShowMainView()
        {
            this.Show();
        }

        public Panel GetUserControlPanel()
        {
            return userControlPanel;
        }

        private void MainView_Load(object sender, EventArgs e)
        {
           
            EventHelpers.RaiseEvent(objectRaisingEvent: this, eventHandlerRaised: MainViewLoadedEventRaised, eventArgs: e);


            _userControlPanelOrigValues = new Panel();

            _userControlPanelOrigValues.Height = userControlPanel.Height;
            _userControlPanelOrigValues.Width = userControlPanel.Width;
            _userControlPanelOrigValues.Location = new Point(userControlPanel.Location.X, userControlPanel.Location.Y);
        }
    }
}
