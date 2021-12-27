using CRUDWinForm.Presenters;
using CRUDWinForm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using Unity.Lifetime;
using Unity.Injection;
using ServiceLayer.Common_Services;
using InfrastructureLayer.DataAccess.Repositories.Employee;
using ServiceLayer.Services.EmployeeServices;
using CRUDWinForm.Presenters.UserControls;
using ServiceLayer.EmployeeServices;
using CRUDWinForm.Views.UserControls;
using DomainLayer.Models.Employee;

namespace CRUDWinForm
{
    static class Program
    {

      

      

        [STAThread]
        static void Main()
        {
            IUnityContainer UnityC;

            //string _connectionString = "Data Source=F:\\Gowthaman\\temp\\MVPDemo\\db\\MDIS.sqlite;Version = 3;";

            string _connectionString = "Data Source=AMIT-DEV4\\MSSQL2017DEV4;Initial Catalog=EmployeeDB;Integrated Security=SSPI";



            UnityC =
         new UnityContainer()
         .RegisterType<IMainView, MainView>(new ContainerControlledLifetimeManager())
         .RegisterType<IMainPresenter, MainPresenter>(new ContainerControlledLifetimeManager())         
         .RegisterType<IEmployeeListViewUC, EmployeeListViewUC>(new ContainerControlledLifetimeManager())
         .RegisterType<IEmployeeListPrsenter, EmployeeListPresenter>(new ContainerControlledLifetimeManager())
         .RegisterType<IEmployeeServices, EmployeeServices>(new ContainerControlledLifetimeManager())
         .RegisterType<IEmployeeRepository, EmployeeRepository>(new InjectionConstructor(_connectionString))
         

         .RegisterType<IEmployeeModel, EmployeeModel>(new ContainerControlledLifetimeManager())
         
         .RegisterType<IModelDataAnnotationCheck, ModelDataAnnotationCheck>(new ContainerControlledLifetimeManager());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            IMainPresenter mainPresenter = UnityC.Resolve<MainPresenter>();

            IMainView mainView = mainPresenter.GetMainView();          

            Application.Run((MainView)mainView);
        }
    }
}
