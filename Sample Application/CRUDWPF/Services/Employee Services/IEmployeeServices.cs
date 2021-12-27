using CRUDWPF.Helpers;
using CRUDWPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWPF.Services.Employee_Services
{
    public interface IEmployeeServices
    {
        event EventHandler<EmployeeEventArgs> EmployeeViewModelNotifier;
        IEnumerable<Employee> GetAll();

        void Add(IEmployee employee);

        void Update(IEmployee employee);

        void Delete(IEmployee employee);

        void DeleteById(IList<Employee> employees);

    }
}
