using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interactive_Employeee_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> myWorkers = new List<Employee>();
            bool addNewEmployee = true;
            while (addNewEmployee)
            {
                Employee myEmployee = new Employee();
                Console.Title = ("Iyke's Employee Management v 2");
                Console.WriteLine("Welcome To Iyke's Employee Management\n");
                Console.WriteLine("Add An Employee First Name\n");
                Console.Write("Enter First Name\n");
                myEmployee.FirstName = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("Add An Employee Last Name\n");
                Console.Write("Enter Last Name\n");
                myEmployee.LastName = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("Add Employee Date Of Birth\n");
                Console.Write("Enter Date Of Birth\n");
                myEmployee.DateOfBirth = Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("Add Employee Social Security Number\n");
                Console.Write("Enter SoS#\n");
                myEmployee.SosNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Add This Employee's PayGrade\n");
                Console.Write("Enter Employee Paygrade\n");
                myEmployee.PayGrade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("Add This Employee's PayRate\n");
                Console.Write("Enter Employee PayRate\n");
                myEmployee.PayRate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("How Many Hours Has Employee Worked\n");
                Console.Write("Enter Hrs Worked\n");
                myEmployee.HoursWorked = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                Console.WriteLine("When Was This Employee Hired");
                Console.Write("Enter Date Hired\n");
                myEmployee.HireDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("\n");
                myWorkers.Add(myEmployee);
                Console.WriteLine("Do you Wish to Add A New Employee? (y/n)");
                string userValue = Console.ReadLine();

                if (userValue == "y")

                {

                    addNewEmployee = true;

                }

                else

                {

                    addNewEmployee = false;

                }
                for (int i = 0; i < myWorkers.Count; i++)
                {
                    if (userValue == "n")
                    {

                        Console.WriteLine(myWorkers[i].FirstName + " has been paid. " + "$" + myWorkers[i].PayRate * myWorkers[i].HoursWorked);
                        Console.WriteLine("\n");

                    }



                    Console.ReadLine();

                }

            }

        }
    }
}