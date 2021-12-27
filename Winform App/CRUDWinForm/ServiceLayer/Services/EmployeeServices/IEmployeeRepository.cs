using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Employee;

namespace ServiceLayer.Services.EmployeeServices
{
    public interface IEmployeeRepository
    {
        IEnumerable<EmployeeModel> GetAll();

        void Add(IEmployeeModel employeeModel);


        void Update(IEmployeeModel employeeModel);

        void Delete(IEmployeeModel employeeModel);
    }
}
