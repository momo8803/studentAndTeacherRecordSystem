using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam
{
    class Student:Person
    {
        string StudentID;
        string CohortNumber;
        double Balance;
        string SemesterID;


        public Student(string studentID,string cohortNumber,
                       double balance,string semesterID,
                       string firstName, string lastName,
                       int departmentCode) :base(firstName, lastName, departmentCode)
        {
            this.StudentID = studentID;
            this.CohortNumber = cohortNumber;
            this.Balance = balance;
            this.SemesterID = semesterID;
                

        }

        public override string toString()
        {
            return "StudentID: " + this.StudentID + "  CohortNumber: " + this.CohortNumber +
                   "  Balance: " + this.Balance + "  SemesterID: " + this.SemesterID +
                   " " + base.toString();
        }

        public string GetID()
        {
            return this.StudentID;
        }

        public string GetCohortNumber()
        {
            return this.CohortNumber;
        }

        public double GetBalance()
        {
            return this.Balance;
        }

        public string studentID
        {
            get { return this.StudentID; }
            set { this.StudentID = value; }
        }
        public string cohortNumber
        {
            get { return this.CohortNumber; }
            set { this.CohortNumber = value; }
        }
        public double balance
        {
            get { return this.Balance; }
            set { this.Balance = value; }
        }
        public string semesterID
        {
            get { return this.SemesterID; }
            set { this.SemesterID = value; }
        }
        //public int departmentCode
        //{
        //    get { return this.DepartmentCode; }
        //    set { this.DepartmentCode = value; }
        //}





    }
}
