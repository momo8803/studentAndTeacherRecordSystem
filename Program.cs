using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermExam
{
    internal class Program
    {
        static void Main()
        {
            School school = new School();
            int choice = 0;

            while (choice != 5)
            {
                Console.WriteLine("###########################");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show All Student");
                Console.WriteLine("3. Add Teacher");
                Console.WriteLine("4. Show All Teacher");
                Console.WriteLine("5. Exit");
                Console.WriteLine("6. Save Student Info into File ");
                Console.WriteLine("7. Change Balance ");
                Console.WriteLine("8. Show Balance ");
                Console.WriteLine("9. Change CohortNumber ");
                Console.WriteLine("10. Increment Teacher Experience ");
                Console.WriteLine("11. Increment TeacherHour ");
                Console.WriteLine("12. Decrement TeacherHour ");
                Console.WriteLine("13. Find Teacher Above Five Year Experience ");
                Console.WriteLine("14. Remove Student From Semester ");               
                Console.WriteLine("#############################");

                do
                {
                    try
                    {
                        Console.WriteLine("please enter your choice");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice < 1 || choice > 14)
                        {
                            Console.WriteLine("Wrong choice, please try again");
                        }
                    }
                    catch (Exception exp)
                    {
                        Console.WriteLine(exp.Message);
                    }


                } while (choice < 1 || choice > 14);



                switch (choice)
                {
                    case 1:
                        school.addStudent();
                        
                        break;
                    case 2:
                        school.displayAllStudent();                                              
                        break;
                    case 3:
                        school.addTeacher();
                        break;
                    case 4:
                        school.displayAllTeacher();
                        break;
                    case 5:
                        Console.WriteLine("Bye Bye");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                    case 6:
                        school.saveStudentsInformationIntoFile();
                        break;
                    case 7:
                        school.addBalance();
                        break;
                    case 8:
                        school.displayBalance();
                        break;
                    case 9:
                        school.changeCohortNumber();
                        break;
                    case 10:
                        school.IncrementTeacherExp();                       
                        break;
                    case 11:
                        school.IncrementTeacherHour();
                        break;
                    case 12:
                        school.decrementTeacherHour();
                        break;
                    case 13:
                        school.findTeacherAboveFiveYearExp();
                        break;
                    case 14:
                        school.removeStudentFromSemester();
                        break;
                    default:
                        Console.WriteLine("Wrong Input!");
                        break;



                }

            }
        }
    }
}
