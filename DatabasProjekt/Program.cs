using System;
using System.Linq;
using DatabasProjekt.Models;

namespace DatabasProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            using TestSchool2DbContext Context = new TestSchool2DbContext();

            bool go = true;
            while (go)
            {
                Console.WriteLine("Choose one of the menu choices:");
                Console.WriteLine("\n\t[1] Amount of teachers in departments\n" +
                    "\t[2] Print out all students\n" +
                    "\t[3] List of all active courses\n" +
                    "\t[4] End");
                Console.Write("Menu choice: ");
                int choices;
                int.TryParse(Console.ReadLine(), out choices);
                switch (choices)
                {
                    case 1:
                        Console.WriteLine("Teacher departments:");
                        Console.WriteLine("\n\tLanguage\n" + "\tScience\n" +
                            "\tSocial\n" + "\tActivity\n");
                        Console.Write("Pick a department: ");
                        string department = Console.ReadLine();

                        var td = from TblTeachers in Context.TblTeachers
                                 orderby TblTeachers.TeacherId
                                 where TblTeachers.Tdepartment == department
                                 select TblTeachers;
                        var count = td.Count();
                        Console.WriteLine("Number of teachers in the department: " + count);
                        foreach (var items in td)
                        {
                            Console.WriteLine(items.TeacherId + " " + "-" + " " + items.Tname);
                        }
                        break;

                    case 2:
                        Console.WriteLine("List of students:");
                        var student = from TblStudents in Context.TblStudents
                                      where TblStudents.Fname == TblStudents.Fname
                                      orderby TblStudents.Fname ascending
                                      select TblStudents;

                        foreach (var item in student)
                        {
                            Console.WriteLine($"ID: {item.StudentId}");
                            Console.WriteLine($"First name: {item.Fname}");
                            Console.WriteLine($"Last namn: {item.Lname}");
                            Console.WriteLine($"Year: {item.ClassYear}");
                            Console.WriteLine($"Social number: {item.SocNum}");
                            Console.WriteLine($"Address: {item.Address}");
                            Console.WriteLine(new string('-', (20)));
                        }
                        break;

                    case 3:
                        Console.WriteLine("List of active courses:");
                        var courses = from Course in Context.Course
                                      orderby Course.CourseId
                                      where Course.IsActive == "Active"
                                      select Course;
                        foreach (var items in courses)
                        {
                            Console.WriteLine(items.CourseId + " " + "-" + " " + items.CourseName);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        Console.ReadKey();
                        go = false;
                        break;
                    default:
                        Console.WriteLine("Please choose between 1-4 in the menu.");
                        break;
                }

            }
        }
    }
}
