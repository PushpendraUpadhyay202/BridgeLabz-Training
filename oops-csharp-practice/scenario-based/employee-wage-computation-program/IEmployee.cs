using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal interface IEmployee
    {
        public Employee AddEmployee();
        public bool CheckEmployeeAttendance();
    }
}
