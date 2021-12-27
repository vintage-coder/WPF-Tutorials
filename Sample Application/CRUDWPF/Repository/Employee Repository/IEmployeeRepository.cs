using CRUDWPF.Helpers;
using CRUDWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWPF.Repository.Employee_Repository
{
    public interface IEmployeeRepository
    {
        event EventHandler<EmployeeEventArgs> EmployeeServiceNotifier;
        void Add(IEmployee employee);

        void Update(IEmployee employee);

        void Delete(IEmployee employee);

        void DeleteById(IList<Employee> employees);

        IEnumerable<Employee> GetAll();
    }
}
