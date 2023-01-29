using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam
{
    class Teacher:Person
    {
        string TeacherID;
        int YearsOfExperience;
        double TeachingHours;

        public Teacher(string teacherID,int yearsOfExperience,
                       double teachingHours, string firstName, string lastName,
                       int departmentCode) : base(firstName, lastName, departmentCode)
        {
            this.TeacherID = teacherID;
            this.YearsOfExperience = yearsOfExperience;
            this.TeachingHours = teachingHours;
        }


        public override string toString()
        {
            return "TeacherID: " + this.TeacherID + 
                   "  Years Of Experience: " + this.YearsOfExperience +
                   "  Teaching Hours: " + this.TeachingHours +
                   " " + base.toString();
        }

        public string GetID()
        {
            return this.TeacherID;
        }
        public int GetYearsOfExperience()
        {
            return this.YearsOfExperience;
        }

        public double GetTeachingHours()
        {
            return this.teachingHours;
        }

        public string teacherID
        {
            get { return this.TeacherID; }
            set { this.TeacherID = value; }
        }

        public int yearsOfExperience
        {
            get { return this.YearsOfExperience; }
            set { this.YearsOfExperience = value; }
        }
        public double teachingHours
        {
            get { return this.TeachingHours; }
            set { this.TeachingHours = value; }
        }
    
    }
}
