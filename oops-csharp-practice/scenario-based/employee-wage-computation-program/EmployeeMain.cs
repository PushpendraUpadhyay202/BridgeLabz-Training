using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal class EmployeeMain
    {
        public static Employee[] employees;
        public static int count = 0;
        public static int totalEmployees = 20;

        static EmployeeMain()
        {
            employees = new Employee[totalEmployees];
            employees[count++] = new Employee(1, "Amit", 18, true, "full time");
            employees[count++] = new Employee(2, "Ragav", 16, true, "full time");
            employees[count++] = new Employee(3, "Arun", 20, false, "full time");
            employees[count++] = new Employee(4, "Anjali", 8, true, "part time");

        }
        public static void Main(string[] args)
        {
            EmployeeMenu EmployeeMenuObject = new EmployeeMenu();
            EmployeeMenuObject.Menu();
        }
    }
}
