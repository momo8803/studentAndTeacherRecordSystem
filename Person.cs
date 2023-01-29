using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam
{
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int DepartmentCode;

        public Person(string firstName, string lastName, int departmentCode)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DepartmentCode = departmentCode;

        }

        public virtual string toString()
        {
            return "\nFirst Name: " + this.FirstName + 
                   "  Last Name: " + this.LastName + 
                   "  Department Code: " + this.DepartmentCode;
        }


    }
}
