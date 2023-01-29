using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MidTermExam
{
    public class School
    {
        public School() { }
        Students myStudents = new Students();
        Teachers myTeachers = new Teachers();

        public bool studentVerifier(string sID)
        {
            bool flag = false;
            foreach (Student stu in myStudents)
            {
                if (stu.GetID() == sID)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public bool teacherVerifier(string tID)
        {
            bool flag = false;
            foreach (Teacher tea in myTeachers)
            {
                if (tea.GetID() == tID)
                {
                    flag = true;
                }
            }
            return flag;
        }


        public void addStudent()
        {
            Console.WriteLine("Please enter the studentID: ");
            string studentID = Console.ReadLine();
            if (studentID.Length != 6)
            {
                Console.WriteLine("Error. The studentID should be 6 chars.");
                Console.ReadKey();
            }
            else
            {
                if (studentVerifier(studentID) == true)
                {
                    Console.WriteLine("Error! There exist this ID for another student!");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Please enter the firstname: ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Please enter the lastname");
                    string lastname = Console.ReadLine();
                    if (firstname.Length + lastname.Length > 35)
                    {
                        Console.WriteLine("Error! Names should be 35 chars");
                    }
                    else
                    {
                        Console.WriteLine("Please enter DepartmentCode(Numbers only): ");
                        int departmentCode = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter CohortNumber: ");
                        string cohortNumber = Console.ReadLine();

                        Console.WriteLine("Please enter the Balance: ");
                        double balance = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Please enter SemesterID(6 chars only): ");
                        string semesterID = Console.ReadLine();
                        if (semesterID.Length != 6)
                        {
                            Console.WriteLine("Error. The semesterID should be 6 chars.");
                            Console.ReadKey();
                        }
                        else
                        {
                            Student student = new Student(studentID,cohortNumber,balance,
                                                          semesterID,firstname,lastname,departmentCode);

                            myStudents.add(student);
                            Console.WriteLine("Success! The student added to the list");
                            Console.ReadLine();
                        }
                    }
                }
            }
        }




        public void addTeacher()
        {
            Console.WriteLine("Please enter the teacherID: ");
            string teacherID = Console.ReadLine();
            if (teacherID.Length != 6)
            {
                Console.WriteLine("Error. The teacherID should be 6 chars.");
                Console.ReadKey();
            }
            else
            {
                if (teacherVerifier(teacherID) == true)
                {
                    Console.WriteLine("Error! There exist this ID for another teacher!");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("Please enter the firstname: ");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Please enter the lastname");
                    string lastname = Console.ReadLine();
                    if (firstname.Length + lastname.Length > 35)
                    {
                        Console.WriteLine("Error! Names should be 35 chars");
                    }
                    else
                    {
                        Console.WriteLine("Please enter DepartmentCode(Numbers only): ");
                        int departmentCode = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter Years Of Experience: ");
                        int yearsOfExperience = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter the Teaching Hours: ");
                        double teachingHours = Convert.ToDouble(Console.ReadLine());

                   
                        Teacher teacher = new Teacher(teacherID,yearsOfExperience,
                        teachingHours, firstname, lastname, departmentCode);

                        myTeachers.add(teacher);
                        Console.WriteLine("Success! The teacher added to the list");
                        Console.ReadLine();
                        
                    }
                }
            }
        }

        public void displayAllStudent()
        {
            foreach (Student stu in myStudents)
            {
                Console.WriteLine(stu.toString());
                Console.WriteLine("---------------------------------------------------");
                

            }
        }

        public void displayAllTeacher()
        {
            foreach (Teacher tea in myTeachers)
            {
                Console.WriteLine(tea.toString());
                Console.WriteLine("---------------------------------------------------");


            }
        }

        public void saveStudentsInformationIntoFile()
        {
            
            try
            {
                using (StreamWriter SW = new StreamWriter(@"C:\Users\mosik\source\C2\MidTermExam\students.txt"))
                {
                    foreach (Student stu in myStudents)
                    {
                        SW.WriteLine(stu.toString());
                    }
                }
                Console.WriteLine("Success! Records added to the file!");
            }
            catch (Exception ex)
            {
                Console.WriteLine( ex.ToString());
            }
            
        }


        public void removeStudentFromSemester()
        {
            Console.Write("Please enter student ID: ");
            string studentID = Console.ReadLine();
            if (studentVerifier(studentID) == false)
            {
                Console.WriteLine("Error! student ID Not Found.");
            }
            else
            {
                Console.Write("Please enter Semester ID: ");
                string semID = Console.ReadLine();

                for (int i = 0; i < myStudents.Count; i++)
                {
                    if (myStudents[i].semesterID.Equals(semID))
                    {
                        myStudents.RemoveAt(i);
                        Console.WriteLine("Student is removed!");
                    }
                    else
                    {
                        Console.WriteLine("s id not match");
                    }
                }
            }
        }


        public void addBalance()
        {
            Console.Write("Please enter student ID: ");
            string studentID = Console.ReadLine();
            if(studentVerifier(studentID)==false) 
            {
                Console.WriteLine("Error! student ID Not Found.");
            }
            else
            {
                Console.WriteLine("how much you wanna add?: ");
                double newBalance = Convert.ToDouble(Console.ReadLine());
                foreach (Student stu in myStudents)
                {
                    stu.balance += newBalance;
                    Console.WriteLine("Balance has been updated.");
                }
            }
        }

        public void displayBalance()
        {
            Console.Write("Please enter student ID: ");
            string studentID = Console.ReadLine();
            if (studentVerifier(studentID) == false)
            {
                Console.WriteLine("Error! student ID Not Found.");
            }
            else
            {
                
                foreach (Student stu in myStudents)
                {      
                    Console.WriteLine("Balance is: " + stu.balance);
                }
            }
        }

        public void changeCohortNumber()
        {
            Console.Write("Please enter student ID: ");
            string studentID = Console.ReadLine();
            if (studentVerifier(studentID) == false)
            {
                Console.WriteLine("Error! student ID Not Found.");
            }
            else
            {
                Console.WriteLine("Enter New Cohort Number: ");
                string newCN = Console.ReadLine();
                foreach (Student stu in myStudents)
                {
                    stu.cohortNumber = newCN;
                    
                    Console.WriteLine("Cohort Number has been updated.");
                }
            }
        }

        public void IncrementTeacherExp()
        {
            Console.Write("Please enter teacher ID: ");
            string teacherID = Console.ReadLine();
            if (teacherVerifier(teacherID) == false)
            {
                Console.WriteLine("Error! teacher ID Not Found.");
            }
            else
            {
                Console.WriteLine("how many year you wanna increase?: ");
                int newYear = Convert.ToInt32(Console.ReadLine());
                foreach (Teacher tea in myTeachers)
                {
                    tea.yearsOfExperience += newYear;
                    
                    Console.WriteLine("Years Of Experience has been updated.");
                }
            }
        }

        public void IncrementTeacherHour()
        {
            Console.Write("Please enter teacher ID: ");
            string teacherID = Console.ReadLine();
            if (teacherVerifier(teacherID) == false)
            {
                Console.WriteLine("Error! teacher ID Not Found.");
            }
            else
            {
                Console.WriteLine("how many hours you wanna increase?: ");
                int newHour = Convert.ToInt32(Console.ReadLine());
                foreach (Teacher tea in myTeachers)
                {
                    tea.teachingHours += newHour;                  
                    Console.WriteLine("Teaching Hour has been updated.");
                }
            }
        }

        public void decrementTeacherHour()
        {
            Console.Write("Please enter teacher ID: ");
            string teacherID = Console.ReadLine();
            if (teacherVerifier(teacherID) == false)
            {
                Console.WriteLine("Error! teacher ID Not Found.");
            }
            else
            {
                Console.WriteLine("how many hours you wanna decrease?: ");
                int newHour = Convert.ToInt32(Console.ReadLine());
                foreach (Teacher tea in myTeachers)
                {
                    tea.teachingHours -= newHour;
                    Console.WriteLine("Teaching Hour has been updated.");
                }
            }
        }

        public void findTeacherAboveFiveYearExp()
        {       
            foreach (Teacher tea in myTeachers)
            {
                if (tea.yearsOfExperience >= 5)
                {
                    Console.WriteLine(tea.toString());
                }
                else
                {
                    Console.WriteLine("Cant find any");
                }
            }            
        }

















    }
}
