using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace CRUDWPF.SplashScreens
{
   
    public partial class SplashScreen : Window
    {
        DispatcherTimer DT = new DispatcherTimer();
        public SplashScreen()
        {
            InitializeComponent();

            DT.Tick += DT_Tick;

            DT.Interval = new TimeSpan(0, 0, 2);
            DT.Start();
        }

        private void DT_Tick(object sender, EventArgs e)
        {
            //MainWindow window = new MainWindow();

            //window.Show();

            //DT.Stop();

            //this.Close();
        }
    }
}
