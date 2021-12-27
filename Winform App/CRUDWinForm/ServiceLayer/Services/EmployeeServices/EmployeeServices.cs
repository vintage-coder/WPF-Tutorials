using DomainLayer.Models.Employee;
using ServiceLayer.Common_Services;
using ServiceLayer.Services.EmployeeServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceLayer.EmployeeServices
{
    public class EmployeeServices : IEmployeeServices, IEmployeeRepository
    {
        IEmployeeRepository _employeeRepository;
        IModelDataAnnotationCheck _modelDataAnnotationCheck;

        BindingList<EmployeeModel> _employeeModelBindingList;

        public EmployeeServices(IEmployeeRepository employeeRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _employeeRepository = employeeRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }


        public void Add(IEmployeeModel employeeModel)
        {
            ValidateModel(employeeModel);
            _employeeRepository.Add(employeeModel);
        }


        public void Update(IEmployeeModel employeeModel)
        {
            ValidateModel(employeeModel);
            _employeeRepository.Update(employeeModel);
        }


        public void Delete(IEmployeeModel employeeModel)
        {
            _employeeRepository.Delete(employeeModel);
        }

        public IEnumerable<EmployeeModel> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public void ValidateModel(IEmployeeModel employeeModel)
        {
            _modelDataAnnotationCheck.ValidateModelDataAnnotations(employeeModel);
        }

        public void BuildDatasourceForAllEmployeeList(BindingSource employeeListBindingSource)
        {
            IEnumerable<EmployeeModel> allemployees = GetAll();

            _employeeModelBindingList = new BindingList<EmployeeModel>();
            foreach (EmployeeModel employeeModel in allemployees)
            {
                _employeeModelBindingList.Add(employeeModel);
            };

            employeeListBindingSource.DataSource = _employeeModelBindingList;
        }
    }
}
