using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Windows.Controls;
using System.Windows.Data;


namespace CRUDWPF.Models
{
    public class Employee : INotifyPropertyChanged  //,IDataErrorInfo
, IEmployee
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

            }
        }

        private int emp_id;
        private string first_name;
        private string last_name;
        private string email_id;
        private bool is_member;
        private bool _status;
        private DateTime dob;
        private Roles _role;


        public int EMPID
        {
            get
            {
                return emp_id;
            }
            set
            {
                if (emp_id != value)
                {
                    emp_id = value;
                    OnPropertyChanged("EMPID");
                }

            }
        }

        public string FirstName
        {
            get
            {
                return first_name;
            }
            set
            {
                if (first_name != value)
                {
                    first_name = value;
                    OnPropertyChanged("FirstName");
                }

            }
        }


        public string LastName
        {
            get
            {
                return last_name;
            }
            set
            {
                if (last_name != value)
                {
                    last_name = value;
                    OnPropertyChanged("LastName");
                }

            }
        }


        public string Email
        {
            get
            {
                return email_id;
            }
            set
            {
                if (email_id != value)
                {
                    email_id = value;
                    OnPropertyChanged("Email");
                }

            }
        }

        public bool IsMember
        {
            get
            {
                return is_member;
            }
            set
            {
                if (is_member != value)
                {
                    is_member = value;
                    OnPropertyChanged("IsMember");
                }

            }
        }

        public bool Status
        {
            get
            {
                return _status;
            }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnPropertyChanged("Status");
                }

            }
        }


        public DateTime DOB
        {
            get
            {
                //return DateTime.Today;
                return dob;
            }
            set
            {
                if (dob != value)
                {
                    dob = value;
                    OnPropertyChanged("DOB");
                }

            }
        }

        public Roles Role
        {
            get
            {
                return _role;
            }
            set
            {
                if (_role != value)
                {
                    _role = value;
                    OnPropertyChanged("Role");
                }
            }
        }

        //public string Error
        //{
        //    get
        //    {
        //        return null;
        //    }
        //}

        //public string this[string propertyName]
        //{


        //    get
        //    {
        //        string result = string.Empty;

        //        switch (propertyName)
        //        {
        //            case "firstname":
        //                if (string.IsNullOrEmpty(FirstName))
        //                {
        //                    result = "empid is required";
        //                }
        //                break;
        //            default:
        //                break;
        //        }
        //        return result;
        //    }



        //}

    }

    public enum Roles
    {
        Engineer,
        Scientist,
        Developer,
        Tester,
        Support
    }

    //public class EmployeeValidationRule : ValidationRule
    //{
    //    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    //    {
    //        Employee employee = (value as BindingGroup).Items[0] as Employee;
    //        if (string.IsNullOrEmpty(employee.FirstName))
    //        {
    //            return new ValidationResult(false,
    //                "First name Can't be empty");
    //        }
    //        else if(string.IsNullOrEmpty(employee.LastName))
    //        {
    //            return new ValidationResult(false,
    //               "Last Name Can't be empty");
    //        }
    //        else if(string.IsNullOrEmpty(employee.Email))
    //        {
    //            return new ValidationResult(false,
    //               "Email Can't be empty");
    //        }
    //        else
    //        {
    //            return ValidationResult.ValidResult;
    //        }
    //    }
    //}


}
