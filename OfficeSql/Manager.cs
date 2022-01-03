using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeSql
{
    public class Manager
    {
        string firstName;
        string lastName;
        string yearOfBirth;
        string email;
        string Department;

        public Manager(string firstName, string lastName, string yearOfBirth, string email, string department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.yearOfBirth = yearOfBirth;
            this.email = email;
            this.Department = department;
        }
    }
}
