using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    sealed class EmployeeMenu
    {
        private IEmployee employeeUtility;
        public void Menu()
        {
            employeeUtility = new EmployeeUtilityImpl();
            Console.WriteLine("\n-------   Welcome to Employee Wage Computation Program    -------");
            while (true)
            {
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2. Check employee Attendance");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 0:
                        Console.WriteLine("Program Exiting......");
                        return;
                    case 1:
                        if(EmployeeMain.count < EmployeeMain.employees.Length)
                        {
                            Employee employee = employeeUtility.AddEmployee();
                            EmployeeMain.employees[EmployeeMain.count++] = employee;
                            Console.WriteLine("Employee Added Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Employee Array is full");
                        }
                            break;
                    case 2:
                        bool employeeAttendance = employeeUtility.CheckEmployeeAttendance();
                        Console.WriteLine("Attendance: " + employeeAttendance + "\n");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Enter option in between 0 to 4 only");
                        break;
                }
            }
        }
    }
}
