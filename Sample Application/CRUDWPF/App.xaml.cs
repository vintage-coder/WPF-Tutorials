using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using CRUDWPF.ViewModels;
using System.Threading;
using Ninject;
using CRUDWPF.Services.Employee_Services;
using CRUDWPF.Repository.Employee_Repository;
using CRUDWPF.Models;
using System.Windows.Threading;
using CRUDWPF.SplashScreen;

namespace CRUDWPF
{ 
    public partial class App : Application
    {
        DispatcherTimer DT = new DispatcherTimer();
        public App()
        {
           
        }


     

        private void Application_Startup(object sender, StartupEventArgs e)
        {


          
            DT.Tick += DT_Tick;

            DT.Interval = new TimeSpan(0, 0, 2);
            DT.Start();


            //private void DT_Tick(object sender, EventArgs e)
            //{
            //    MainWindow window = new MainWindow();

            //    window.Show();

            //    DT.Stop();

            //    this.Close();
            //}



            //IKernel kernel = new StandardKernel();
            //kernel.Bind<IEmployeeServices>().To<EmployeeServices>();
            //kernel.Bind<IEmployeeRepository>().To<EmployeeRepository>();
            //kernel.Bind<IEmployee>().To<Employee>();

            EmployeeRepository employeeRepository = new EmployeeRepository();

            EmployeeServices services = new EmployeeServices(employeeRepository);

            EmployeeViewModel EVM = new EmployeeViewModel(services);

            //var EVM = kernel.Get<EmployeeViewModel>();

            MainWindow = new MainWindow(services);
            MainWindow.DataContext = EVM;
            MainWindow.Show();
        }


        private void DT_Tick(object sender, EventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();

            splashScreen.Show();

            DT.Stop();

            splashScreen.Close();
            
        }
    }
}
