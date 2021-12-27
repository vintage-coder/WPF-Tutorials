using CRUDWPF.Helpers;
using CRUDWPF.Models;
using CRUDWPF.Repository.Employee_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWPF.Services.Employee_Services
{
    public class EmployeeServices : IEmployeeServices, IEmployeeRepository
    {
        IEmployeeRepository _EmployeeRepository;

       

        public event EventHandler<EmployeeEventArgs> EmployeeServiceNotifier;
        public event EventHandler<EmployeeEventArgs> EmployeeViewModelNotifier;

        public EmployeeServices(IEmployeeRepository EmployeeRepository)
        {
            _EmployeeRepository = EmployeeRepository;

            Subscribe();
        }

        private void Subscribe()
        {
            _EmployeeRepository.EmployeeServiceNotifier += _EmployeeRepository_EmployeeServiceNotifier;
        }

        private void _EmployeeRepository_EmployeeServiceNotifier(object sender, EmployeeEventArgs e)
        {
            Console.WriteLine("Update database event completed.....**** "+e.name);
            EventHelpers.FiresEvent(this, EmployeeViewModelNotifier, new EmployeeEventArgs() { name = "geek1" });
        }

     

        public void Add(IEmployee employee)
        {
            _EmployeeRepository.Add(employee);
        }

        public void Delete(IEmployee employee)
        {
            _EmployeeRepository.Delete(employee);
        }

        public IEnumerable<Employee> GetAll()
        {
           return _EmployeeRepository.GetAll();
        }

        public void Update(IEmployee employee)
        {
            _EmployeeRepository.Update(employee);
        }

        public void DeleteById(IList<Employee> employees)
        {
            _EmployeeRepository.DeleteById(employees);
        }
    }
}
