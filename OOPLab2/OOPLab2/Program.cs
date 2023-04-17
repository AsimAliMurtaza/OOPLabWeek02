using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab2
{
    public class Students
    {
        public string studentName;
        public int rollNumber;
        public float gpa;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Students stdOne = new Students();
            Students stdTwo = new Students();

            //taskTwo(stdOne);
            //taskThree(stdOne, stdTwo);
            //taskFour(stdOne);
            taskFive();
        }
        static void taskTwo(Students stdOne)
        {
            stdOne.studentName = "Asim";
            stdOne.rollNumber = 175;
            stdOne.gpa = 3.7f;

            Console.WriteLine("Student Name: {0}", stdOne.studentName);
            Console.WriteLine("Roll Number: {0}", stdOne.rollNumber);
            Console.WriteLine("GPA: {0}", stdOne.gpa);
        }

        static void taskThree(Students stdOne, Students stdTwo)
        {
            stdOne.studentName = "Asim";
            stdOne.rollNumber = 175;
            stdOne.gpa = 3.7f;

            stdTwo.studentName = "Ali";
            stdTwo.rollNumber = 310;
            stdTwo.gpa = 3.5f;

            Console.WriteLine("Student Name: {0}", stdOne.studentName);
            Console.WriteLine("Roll Number: {0}", stdOne.rollNumber);
            Console.WriteLine("GPA: {0}", stdOne.gpa);

            Console.WriteLine("Student Name: {0}", stdTwo.studentName);
            Console.WriteLine("Roll Number: {0}", stdTwo.rollNumber);
            Console.WriteLine("GPA: {0}", stdTwo.gpa);
        }

        static void taskFour(Students stdOne)
        {
            Console.Write("Enter Student Name: ");
            stdOne.studentName = Console.ReadLine();
            Console.Write("Enter Roll Number: ");
            stdOne.rollNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter GPA: ");
            stdOne.gpa = float.Parse(Console.ReadLine());

            Console.WriteLine("Student Name: {0}", stdOne.studentName);
            Console.WriteLine("Roll Number: {0}", stdOne.rollNumber);
            Console.WriteLine("GPA: {0}", stdOne.gpa);
        }

        static void taskFive()
        {
            int size = 5;
            int stdCount = 0;
            Student[] stud = new Student[size];

            int choice = 0;

            while(choice !=4)
            {
                choice = choiceReturn();

                if (choice == 1)
                {
                    stud[stdCount] = addStudents();
                    stdCount++;
                }
                if (choice == 2)
                {
                    viewStudents(ref stud, ref stdCount);
                    Console.ReadKey();
                }
                if(choice == 3)
                {
                    ViewTop(ref stud, ref stdCount);
                    Console.ReadKey();
                }
            }
        }
        static int choiceReturn()
        {
            Console.Clear();
            Console.WriteLine("1. Add A Student.");
            Console.WriteLine("2. View Students.");
            Console.WriteLine("3. View Top Students.");
            Console.WriteLine("4. Exit.");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;

        }
        static Student addStudents()
        {
            Student std = new Student();

            Console.Clear();
            Console.Write("Enter name of Student: ");
            std.name = Console.ReadLine();
            Console.Write("Enter Roll Number of Student: ");
            std.rollNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter cgpa of Student: ");
            std.cgpa = float.Parse(Console.ReadLine());
            Console.Write("Enter Accomodation Status of Student: ");
            std.isHostellite = Console.ReadLine();
            Console.Write("Enter Department of Student: ");
            std.department = Console.ReadLine();
            return std;
        }
        static void viewStudents(ref Student[] stud, ref int stdCount)
        {

            Console.Clear();
            for(int i = 0; i<stdCount; i++)
            {
                Console.WriteLine("Student Name: {0}", stud[i].name);
                Console.WriteLine("Roll Number: {0}", stud[i].rollNumber);
                Console.WriteLine("Student CGPA: {0}", stud[i].cgpa);
                Console.WriteLine("Accomodation: {0}", stud[i].isHostellite);
                Console.WriteLine("Department: {0}", stud[i].department);
                Console.WriteLine();
            }
        }
        static int largest(Student[] stud, int start, int stdCount)
        {
            int index = start;
            float large = stud[start].cgpa;

            for (int i = start; i < stdCount; i++)
            {
                if (large < stud[i].cgpa)
                {
                    large = stud[i].cgpa;
                    index = i;
                }
            }
            return index;
        }
        static void ViewTop(ref Student[] std, ref int stdCount)
        {
            if(stdCount == 0)
            {
                Console.Write("No record Exists!");
                Console.ReadKey();
            }
            else if(stdCount == 1)
            {
                viewStudents(ref std, ref stdCount);
            }
            else if( stdCount > 1) 
            {
                for(int i = 0 ; i < stdCount; i++)
                {
                    int index = largest(std, i, stdCount);
                    Student temp = std[index];
                    std[index] = std[i];
                    std[i] = temp;
                }
                viewStudents(ref std, ref stdCount);
            }
        }
    }
}
