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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Configuration;
using System.Data;
using System.ComponentModel;
using System.Collections.ObjectModel;
using CRUDWPF.Commands.Generic;
using CRUDWPF.ViewModels;
using CRUDWPF.Models;
using CRUDWPF.Services.Employee_Services;

namespace CRUDWPF
{
   
    public partial class MainWindow : Window
    {

        IEmployeeServices _employeeServices;
        public MainWindow(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;


            InitializeComponent();
         
        }

       
        
        private void DriversDataGrid_PreviewDeleteCommandHandler(object sender, ExecutedRoutedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
          
            if (e.Command == DataGrid.DeleteCommand)
            {
                if (!(MessageBox.Show("Are you sure you want to delete?", "Please confirm.", MessageBoxButton.YesNo) == MessageBoxResult.Yes))

                {
                     e.Handled = true;

                }
                else
                {
                    List<Employee> employees = dataGrid.SelectedItems.Cast<Employee>().ToList();


                    _employeeServices.DeleteById(employees);

                   
                }

            }
           

        }

        private void DP1_Loaded(object sender, RoutedEventArgs e)
        {

            //DatePicker DP = sender as DatePicker;

            (sender as DatePicker).SelectedDate = DateTime.Now;


            //if (DP.SelectedDate == Convert.ToDateTime("01-01-0001"))
            //{
            //    DP.DisplayDate = DateTime.Now;
            //    //DP.SelectedDate = DateTime.Now;
            //}
            //else
            //{
            //    DP.DisplayDate = (DateTime)DP.SelectedDate;
            //}


        }

        private void DP1_CalendarOpened(object sender, RoutedEventArgs e)
        {
            (sender as DatePicker).DisplayDate = DateTime.Now;
        }

        private void dg1_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            Console.WriteLine("cell editing called..");
            Console.WriteLine((e.Row.Item as Employee).Email);

            _employeeServices.Update((e.Row.Item as Employee));
        }

        private void DP1_Initialized(object sender, EventArgs e)
        {
            //(sender as DatePicker).DisplayDate = DateTime.Now;
        }


     

    }
   
}
