using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSql
{
    public class Employee
    {
        string FirstName;
        string BirthDay;
        string Email;
        int Salary;
        public Employee(string FisrtName,string birthDay,string email,int salary)
        {
            this.FirstName = FisrtName;
            this.BirthDay = birthDay;
            this.Email = email;
            this.Salary = salary;
        }
    }
}
