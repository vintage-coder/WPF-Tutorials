using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using CRUDWPF.Models;
using System.Windows.Input;
using CRUDWPF.Commands.Generic;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Collections.Specialized;
using System.Windows.Data;
using CRUDWPF.Services.Employee_Services;

namespace CRUDWPF.ViewModels
{
    public class EmployeeViewModel:INotifyPropertyChanged
    {
        public ObservableCollection<Employee> employee;
        public event EventHandler EmployeeViewModelNotifier;
        //public ICollectionView EmployeesCollectionView { get; set; }

        private ICollectionView _EmployeesCollectionView;


        IEmployeeServices _employeeServices;

       

        public EmployeeViewModel(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
            IEnumerable<Employee> employees= _employeeServices.GetAll();



            //employee = new ObservableCollection<Employee>(_employeeServices.GetAll());

            employee = new ObservableCollection<Employee>();

            //employee.Add((Employee));

            foreach  (Employee emp in employees)
            {
                employee.Add(emp);
            }
            

            _EmployeesCollectionView = CollectionViewSource.GetDefaultView(employee);



            _EmployeesCollectionView.SortDescriptions.Add(new SortDescription(nameof(Employee.EMPID), ListSortDirection.Ascending));


            SubscribeToEvent();
        }


        //private void UpdateGrid(IEmployeeServices _employeeServices)
        //{
        //    employee.Clear();

        //    IEnumerable<Employee> employees1 = _employeeServices.GetAll();

        //    foreach (Employee emp in employees1)
        //    {
        //        employee.Add(emp);
        //    }

        //}

        private void SubscribeToEvent()
        {
            EmployeesCollectionView.CollectionChanged += EmployeesCollectionView_CollectionChanged;

            _employeeServices.EmployeeViewModelNotifier += _employeeServices_EmployeeViewModelNotifier;
        }

        private void _employeeServices_EmployeeViewModelNotifier(object sender, Helpers.EmployeeEventArgs e)
        {
            Console.WriteLine("Employee view model event was fired......****" + e.name);


            //UpdateGrid(_employeeServices);
            employee.Clear();

            IEnumerable<Employee> emp1 = _employeeServices.GetAll();

            foreach (Employee emp in emp1)
            {
                employee.Add(emp);
            }

            //employee = new ObservableCollection<Employee>(_employeeServices.GetAll());


            //_EmployeesCollectionView = CollectionViewSource.GetDefaultView(employee);

            //_EmployeesCollectionView.SortDescriptions.Add(new SortDescription(nameof(Employee.EMPID), ListSortDirection.Ascending));

            //_EmployeesCollectionView.Refresh();

        }

        private void EmployeesCollectionView_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if(e.Action==NotifyCollectionChangedAction.Add)
            {
                Console.WriteLine("New Item added.."+e.NewItems.Count+"  "+e.NewItems);
                Console.WriteLine("Old Items...." + e.OldItems);

            }
            if (e.Action == NotifyCollectionChangedAction.Remove)
            {
                Console.WriteLine("New Item Removed.." + e.NewItems);
                Console.WriteLine("Old Items...." + e.OldItems);

            }
            if (e.Action == NotifyCollectionChangedAction.Replace)
            {
                Console.WriteLine("New Item Replaced.." + e.NewItems);
                Console.WriteLine("Old Items...." + e.OldItems);

            }
        }

        public ICollectionView EmployeesCollectionView
        {
            get
            {
                return _EmployeesCollectionView;
            }
            set
            {
                  if(_EmployeesCollectionView!=value)
                   {
                        _EmployeesCollectionView = value;
                        OnPropertyChanged("EmployeesCollectionView");
                    }
                 
               
            }
        }

      
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
        }


        private ICommand _InsertCommand;
        private ICommand _UpdateCommand;
        private ICommand _DeleteCommand;
        private ICommand _AddCommand;
        private ICommand _ActivateCommand;
        private ICommand _TestCommand;

        public ICommand ActivatedCommand
        {
            get
            {
                if (_ActivateCommand == null)
                {
                    _ActivateCommand = new RelayCommand(ActivateExecute, CanActivateExecute, false);
                }

                return _ActivateCommand;
            }
        }

        public void ActivateExecute(object parameter)
        {
            Console.WriteLine("Activated Event was Fired...");
            Console.WriteLine("******************************************************************");
        }

        public bool CanActivateExecute(object parameter)
        {
            return true;
        }


        public ICommand InsertCommand
        {
            get
            {
                if (_InsertCommand == null)
                {
                    _InsertCommand = new RelayCommand(InsertExecute, CanInsertExecute, false);
                }

                return _InsertCommand;
            }
        }

        public ICommand UpdateCommand
        {
            get
            {
                if (_UpdateCommand == null)
                {
                    _UpdateCommand = new RelayCommand(UpdateExecute, CanUpdateExecute, false);
                }

                return _UpdateCommand;
            }
        }

        public ICommand DeleteCommand
        {
            get
            {
                if (_DeleteCommand == null)
                {
                    _DeleteCommand = new RelayCommand(DeleteExecute, CanDeleteExecute, false);
                }

                return _DeleteCommand;
            }
        }


        public ICommand AddCommand
        {
            get
            {
                if(_AddCommand==null)
                {
                    _AddCommand = new RelayCommand(AddExecute, CanAddExecute, false);
                }
                return _AddCommand;
            }
        }


        public ICommand TestCommand
        {
            get
            {
                if (_TestCommand == null)
                {
                    _TestCommand = new RelayCommand(TestExecute, CanTestExecute, false);
                }
                return _TestCommand;
            }
        }

        private void AddExecute(object parameter)
        {
            Employee emp = new Employee();

            employee.Add(emp);
        }

        private bool CanAddExecute(object parameter)
        {
            return true;
        }


        private void TestExecute(object parameter)
        {
            Employee emp = (parameter as Employee);
            Console.WriteLine(emp.FirstName);
        }

        private bool CanTestExecute(object parameter)
        {

            return true;
        }


        private void InsertExecute(object parameter)
        {
            _employeeServices.Add((Employee)parameter);

            
        }

        private bool CanInsertExecute(object parameter)
        {
        
            return true;            
        }

        private void UpdateExecute(object parameter)
        {
            _employeeServices.Update((Employee)parameter);
          
        }

        private bool CanUpdateExecute(object parameter)
        {
            return true;
        }

        private void DeleteExecute(object parameter)
        {
            _employeeServices.Delete((Employee)parameter);

        }

        private bool CanDeleteExecute(object parameter)
        {           
            return true;
        }

    }
}



