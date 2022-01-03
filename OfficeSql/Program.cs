using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSql
{
    internal class Program
    {

        public static void DeleteMenagerById(string cs)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    Console.WriteLine("enter id you want Delete");
                    int userId = int.Parse(Console.ReadLine());
                    connection.Open();
                    string query = $@"DELETE FROM Managers WHERE Id={userId} ";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }


            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
    }
        public static void updateManager(string cs)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    Console.WriteLine("enter id you want cange");
                    int userId = int.Parse(Console.ReadLine());
                    Console.WriteLine("ente fisrt name");
                    string menagerName = Console.ReadLine();
                    Console.WriteLine("ente last name");
                    string menagerlastname = Console.ReadLine();
                    Console.WriteLine("ente Year of birth");
                    string ManegerYearOfBirth = (Console.ReadLine());
                    Console.WriteLine("ente email");
                    string managerEmail = Console.ReadLine();
                    Console.WriteLine("enter deprtment");
                    string mangerDepartment = Console.ReadLine();


                    connection.Open();
                    string query = $@"UPDATE Managers SET FirstName='{menagerName}',LastName='{menagerlastname}',YearOfBirth='{ManegerYearOfBirth}',Email='{managerEmail}',Department='{mangerDepartment}' WHERE Id={userId}";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine(rowEffected);
                    connection.Close();


                }


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void showManager(string cs)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();
                    string query = "SELECT * FROM Managers";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                        }
                    }
                    else
                    {
                        Console.WriteLine("TABLE IS EMPTY");
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }
        public static void addManager(string cs)
        {

            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    Console.WriteLine("ente fisrt name");
                    string menagerName = Console.ReadLine();
                    Console.WriteLine("ente last name");
                    string menagerlastname = Console.ReadLine();
                    Console.WriteLine("ente Year of birth");
                    string ManegerYearOfBirth = (Console.ReadLine());
                    Console.WriteLine("ente email");
                    string managerEmail = Console.ReadLine();
                    Console.WriteLine("enter deprtment");
                    string mangerDepartment= Console.ReadLine();
                   

                    connection.Open();
                    string query = $@"INSERT INTO Managers(FirstName,LastName,YearOfBirth,Email,Department) VALUES('{menagerName}','{menagerlastname}',{ManegerYearOfBirth},'{managerEmail}','{mangerDepartment}')";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    Console.WriteLine(rowEffected);
                    connection.Close();


                }


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public static void DeleteById(string cs)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    Console.WriteLine("enter id you want Delete");
                    int userId = int.Parse(Console.ReadLine());
                    connection.Open();
                    string query = $@"DELETE FROM Employees WHERE Id={userId} ";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    connection.Close();

                }
            }


            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void updateEmployee(string cs)
        {
            try
            {

                using (SqlConnection connection = new SqlConnection(cs))
                {
                    Console.WriteLine("enter id you want cange");
                    int userId = int.Parse(Console.ReadLine());
                    Console.WriteLine("ente name");
                    string EmployeName = Console.ReadLine();
                    Console.WriteLine("ente b day");
                    string EmploybirthDy = Console.ReadLine();
                    Console.WriteLine("ente email");
                    string EmployeEmail = Console.ReadLine();
                    Console.WriteLine("ente salary");
                    int EmployeSalary = int.Parse(Console.ReadLine());

                    connection.Open();
                    string query = $@"UPDATE Employees SET FirstName='{EmployeName}', BirthDay='{EmploybirthDy}',Email='{EmployeEmail}', salary={EmployeSalary} WHERE Id={userId} ";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    int rowEffected = cmd.ExecuteNonQuery();
                    connection.Close();


                }
            }


            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static void ShowEmployees(string cs)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    connection.Open();
                    string query = "SELECT * FROM Employees";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                        }
                    }
                    else
                    {
                        Console.WriteLine("TABLE IS EMPTY");
                    }
                }

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }
        }
        public static void addEmployees(string cs)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cs))
                {
                    Console.WriteLine("ente name");
                    string EmployeName=Console.ReadLine();
                    Console.WriteLine("ente b day");
                    string EmploybirthDy = Console.ReadLine();
                    Console.WriteLine("ente email");
                    string EmployeEmail = Console.ReadLine();
                    Console.WriteLine("ente salary");
                    int EmployeSalary =int.Parse( Console.ReadLine());

                    connection.Open();
                    string query = $@"INSERT INTO Employees(FirstName,BirthDay,Email,salary) VALUES('{EmployeName}','{EmploybirthDy}','{EmployeEmail}',{EmployeSalary})";

                    SqlCommand cmd = new SqlCommand(query, connection);
                   int rowEffected=cmd.ExecuteNonQuery();
                    Console.WriteLine(rowEffected);
                    connection.Close();
               

                }


            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>();
            string coonecitonString = @"Data Source=LAPTOP-E49VKATT;Initial Catalog=OfficeAppDB;Integrated Security=True;Pooling=False";
            //ShowEmployees(coonecitonString);

            //addEmployees(coonecitonString);

            //updateEmployee(coonecitonString);

            //DeleteById(coonecitonString);

            //addManager(coonecitonString);

            //showManager(coonecitonString);

           // updateManager(coonecitonString);



        }

    }
}
