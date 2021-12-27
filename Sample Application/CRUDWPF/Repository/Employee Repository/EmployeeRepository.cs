using CRUDWPF.Helpers;
using CRUDWPF.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CRUDWPF.Repository.Employee_Repository
{
    public class EmployeeRepository:IEmployeeRepository
    {
        public event EventHandler<EmployeeEventArgs> EmployeeServiceNotifier;

        SqlConnection con = null;
        string _connectionString = string.Empty;
        public EmployeeRepository()
        {

            string _connectionString = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;


            Console.WriteLine("===============================================");
            Console.WriteLine(_connectionString);

            try
            {
                con = new SqlConnection(_connectionString);

                con.Open();

                Console.WriteLine("Connection Succeeded...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Opps, Something went wrong,", ex.Message);
            }

        }

     

        public void Add(IEmployee employee)
        {
                if (employee != null)
                {
                    IEmployee emp = employee;

                    SqlCommand cmd = con.CreateCommand();

                    cmd.CommandText = "insert into EmpTbl(first_name,last_name,email_id,is_member,status,dob,role) values(@first_name,@last_name,@email_id,@is_member,@status,@dob,@role) ";

                    cmd.CommandType = CommandType.Text;


                    cmd.Parameters.AddWithValue("@first_name", emp.FirstName.ToString());

                    cmd.Parameters.AddWithValue("@last_name", emp.LastName.ToString());

                    cmd.Parameters.AddWithValue("@email_id", emp.Email.ToString());

                    cmd.Parameters.AddWithValue("@is_member", emp.IsMember == true ? "yes" : "no");

                    cmd.Parameters.AddWithValue("@status", emp.Status == true ? "yes" : "no");

                    cmd.Parameters.AddWithValue("@dob", emp.DOB);

                    cmd.Parameters.AddWithValue("@role", emp.Role.ToString());

                    try
                    {
                        int n = cmd.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("Inserted into db successfully");
                            EventHelpers.FiresEvent(this, EmployeeServiceNotifier, new EmployeeEventArgs { name = "geek" });
                    }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Status");
                    }
                }
         
        }

        public void Delete(IEmployee employee)
        {
            IEmployee emp = employee;

                Console.WriteLine(emp.EMPID + emp.FirstName + emp.LastName + emp.Status + emp.Role + emp.DOB);

                if (employee != null)
                {
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "delete from EmpTbl where emp_id in ( " + emp.EMPID + ")";

                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        int n = cmd.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("Deleteted row successfully");
                          
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }          
        }


        public void DeleteById(IList<Employee> employees)
        {
                       
            Console.WriteLine(employees.Count);
            var query = "delete from EmpTbl where emp_id in ({0})";

            SqlCommand cmd = con.CreateCommand();

            //cmd.CommandText = query;

            cmd.CommandType = CommandType.Text;

            var idParameterList = new List<string>();
            var index = 0;
            foreach (Employee item in employees)
            {
                var paramName = "@idParam" + index;

                cmd.Parameters.AddWithValue(paramName, item.EMPID);
                //SqlCommand.Parameters.AddWithValue(paramName, sessionid);
                idParameterList.Add(paramName);
                index++;
            }
            cmd.CommandText = string.Format(query, string.Join(",", idParameterList));



            try
            {
                int n = cmd.ExecuteNonQuery();

                if (n > 0)
                {
                    MessageBox.Show("Deleted row successfully");

                }
            }
            catch (Exception ex)
            {

            }

        }

        public IEnumerable<Employee> GetAll()
        {

            List<Employee> EmployeeList = new List<Employee>();

            using (SqlConnection sqlConnection = new SqlConnection("Data Source = AMIT-DEV4\\MSSQL2017DEV4; Initial Catalog = EmployeeDB; Integrated Security=SSPI")) 
            {
                string sql = "SELECT * FROM EmpTbl";

                sqlConnection.Open();

                using (SqlCommand cmd = new SqlCommand(sql, sqlConnection))
                {
                    cmd.CommandText = sql;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();

                            employee.EMPID = Convert.ToInt32(reader["emp_id"]);
                            employee.FirstName = reader["first_name"].ToString();
                            employee.LastName = reader["last_name"].ToString();
                            employee.Email = reader["email_id"].ToString();
                            employee.IsMember = reader["is_member"].ToString() == "yes" ? true : false;
                            employee.Status = reader["status"].ToString() == "yes" ? true : false;
                            employee.DOB = Convert.ToDateTime(reader["dob"].ToString());
                            employee.Role = (Roles)Enum.Parse(typeof(Roles), reader["role"].ToString(), true);
                            EmployeeList.Add(employee);


                        }
                    }
                }
            }
            return (IEnumerable<Employee>)EmployeeList;
        }

        public void Update(IEmployee employee)
        {


            IEmployee emp = employee;

                Console.WriteLine(emp.EMPID + emp.FirstName + emp.LastName + emp.Status + emp.Role + emp.DOB);

                if (employee != null)
                {
                    SqlCommand cmd = con.CreateCommand();

                    cmd.CommandText = "update EmpTbl set first_name=@first_name,last_name=@last_name,email_id=@email_id,is_member=@is_member,status=@status,dob=@dob,role=@role where emp_id = @emp_id ";

                    cmd.CommandType = CommandType.Text;



                    cmd.Parameters.AddWithValue("@emp_id", emp.EMPID.ToString());

                    cmd.Parameters.AddWithValue("@first_name", emp.FirstName==null ? null:emp.FirstName.ToString());

                    cmd.Parameters.AddWithValue("@last_name", emp.LastName==null  ? null:emp.LastName.ToString());

                    cmd.Parameters.AddWithValue("@email_id", emp.Email==null ? null: emp.Email.ToString());

                    cmd.Parameters.AddWithValue("@is_member", emp.IsMember == true ? "yes" : "no");

                    cmd.Parameters.AddWithValue("@status", emp.Status == true ? "yes" : "no");

                    cmd.Parameters.AddWithValue("@dob", emp.DOB);

                    cmd.Parameters.AddWithValue("@role", emp.Role.ToString());

                    try
                    {
                        int n = cmd.ExecuteNonQuery();

                        if (n > 0)
                        {
                            MessageBox.Show("Updated into db successfully");

                             

                            EventHelpers.FiresEvent(this, EmployeeServiceNotifier, new EmployeeEventArgs { name="geek" });

                    }
                    }
                    catch (Exception ex)
                    {

                    }

            }

        }
    }

}
