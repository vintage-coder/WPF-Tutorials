using CRUDWPF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace CRUDWPF.Validation
{
    public class EmployeeValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            Employee employee = (value as BindingGroup).Items[0] as Employee;
            if (string.IsNullOrEmpty(employee.FirstName))
            {
                return new ValidationResult(false,
                    "First name Can't be empty");
            }
            else if (string.IsNullOrEmpty(employee.LastName))
            {
                return new ValidationResult(false,
                   "Last Name Can't be empty");
            }
            else if (string.IsNullOrEmpty(employee.Email))
            {
                return new ValidationResult(false,
                   "Email Can't be empty");
            }
            else
            {
                return ValidationResult.ValidResult;
            }
        }
    }

}
