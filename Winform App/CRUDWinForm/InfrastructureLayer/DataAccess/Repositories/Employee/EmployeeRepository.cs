using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using ServiceLayer.Services.EmployeeServices;
using DomainLayer.Models.Employee;

namespace InfrastructureLayer.DataAccess.Repositories.Employee
{
    public class EmployeeRepository: BaseRepository, IEmployeeRepository
    {

        public EmployeeRepository()
        {

        }

        public EmployeeRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

     

        public IEnumerable<EmployeeModel> GetAll()
        {

            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
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
                            EmployeeModel employee = new EmployeeModel();

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
            return (IEnumerable<EmployeeModel>)EmployeeList;
        }


        public void Add(IEmployeeModel employeeModel)
        {
       
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                

                string SqlText =
                       "INSERT INTO EmpTbl (DepartmentName, DepartmentUrl, PhoneNumber, Email, CityLocation, StateLocation) " +
                       "VALUES (@DepartmentName, @DepartmentUrl, @PhoneNumber, @Email, @CityLocation, @StateLocation) ";

                using (SqlCommand cmd = new SqlCommand(SqlText,sqlConnection))
                {
                   
                    cmd.CommandText = SqlText;

                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@EMPID", employeeModel.EMPID);
                    cmd.Parameters.AddWithValue("@FirstName", employeeModel.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", employeeModel.LastName);
                    
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                    }


                    sqlConnection.Close();
                }
            }
        }


        public void Update(IEmployeeModel employeeModel)
        {

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {


                string SqlText =
                       "INSERT INTO EmpTbl (DepartmentName, DepartmentUrl, PhoneNumber, Email, CityLocation, StateLocation) " +
                       "VALUES (@DepartmentName, @DepartmentUrl, @PhoneNumber, @Email, @CityLocation, @StateLocation) ";

                using (SqlCommand cmd = new SqlCommand(SqlText, sqlConnection))
                {

                    cmd.CommandText = SqlText;

                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@EMPID", employeeModel.EMPID);
                    cmd.Parameters.AddWithValue("@FirstName", employeeModel.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", employeeModel.LastName);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                    }


                    sqlConnection.Close();
                }
            }
        }



        public void Delete(IEmployeeModel employeeModel)
        {

            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {


                string SqlText =
                       "INSERT INTO EmpTbl (DepartmentName, DepartmentUrl, PhoneNumber, Email, CityLocation, StateLocation) " +
                       "VALUES (@DepartmentName, @DepartmentUrl, @PhoneNumber, @Email, @CityLocation, @StateLocation) ";

                using (SqlCommand cmd = new SqlCommand(SqlText, sqlConnection))
                {

                    cmd.CommandText = SqlText;

                    cmd.Prepare();
                    cmd.Parameters.AddWithValue("@EMPID", employeeModel.EMPID);
                    cmd.Parameters.AddWithValue("@FirstName", employeeModel.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", employeeModel.LastName);

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException e)
                    {
                    }


                    sqlConnection.Close();
                }
            }
        }



    }
}
