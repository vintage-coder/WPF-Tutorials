using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models.Employee
{


    public class EmployeeModel : IEmployeeModel
    {

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
                }

            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "first name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "first name must be between 5 and 20 characters")]
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
                }

            }
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "last name is required")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "last name must be between 5 and 20 characters")]
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
                }

            }
        }

        [Required(ErrorMessage = "Email is a Required field.")]
        [RegularExpression(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$",
               ErrorMessage = "Email format is incorrect")]
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

                }

            }
        }


        public DateTime DOB
        {
            get
            {

                return dob;
            }
            set
            {
                if (dob != value)
                {
                    dob = value;

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

                }
            }
        }
    }

    public enum Roles
    {
        Engineer,
        Scientist,
        Developer,
        Tester,
        Support
    }

}


