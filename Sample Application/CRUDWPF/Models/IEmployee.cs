using System;

namespace CRUDWPF.Models
{
    public interface IEmployee
    {
        DateTime DOB { get; set; }
        string Email { get; set; }
        int EMPID { get; set; }
        string FirstName { get; set; }
        bool IsMember { get; set; }
        string LastName { get; set; }
        Roles Role { get; set; }
        bool Status { get; set; }
    }
}