using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal class EmployeeUtilityImpl : IEmployee
    {
        private int EmployeeId = 4;

        public Employee AddEmployee()
        {
            Console.Write("Enter Employee Name: ");
            string employeeName = Console.ReadLine();

            Console.Write("Enter employee attendance (true/false): ");
            bool employeeAttendance = bool.Parse(Console.ReadLine());

            Console.Write("Enter wage per hour: ");
            double wagePerHour = double.Parse(Console.ReadLine());

            Console.Write("Enter employee type: ");
            string employeeType = Console.ReadLine();


            Employee employee = new Employee(
                ++EmployeeId,
                employeeName,
                wagePerHour,
                employeeAttendance,
                employeeType
            );
            return employee;
        }

        //UC 1 : Check Employee is Present or Absent
        public bool CheckEmployeeAttendance()
        {
            Console.Write("Enter Employee ID: ");
            int employeeId = int.Parse(Console.ReadLine());

            foreach(Employee employee in EmployeeMain.employees)
            {
                if(employee != null && employee.GetEmployeeId() == employeeId)
                {
                    return employee.GetIsPresent();
                }
            }
            Console.WriteLine("Employee Doesn't exist\n");
            return false;
        }
    }

}