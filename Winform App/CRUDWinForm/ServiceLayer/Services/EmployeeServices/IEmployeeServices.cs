using DomainLayer.Models.Employee;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ServiceLayer.EmployeeServices
{
    public interface IEmployeeServices
    {
        void BuildDatasourceForAllEmployeeList(BindingSource employeeListBindingSource);
        IEnumerable<EmployeeModel> GetAll();
    }
}