using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement
{
    internal class Employee
    {
        private int EmployeeId;
        private string EmployeeName;
        private double WagePerHour;
        private bool IsPresent;
        private string EmployeeType;

        public Employee(int employeeId, string employeeName, double wagePerHour, bool isPresent , string employeeType)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this.WagePerHour = wagePerHour;
            this.IsPresent = isPresent;
            this.EmployeeType = employeeType;
        }

        public int GetEmployeeId()
        {
            return EmployeeId;
        }

        public void SetEmployeeId(int employeeId)
        {
            this.EmployeeId = employeeId;
        }

        public string GetEmployeeName()
        {
            return EmployeeName;
        }

        public void SetEmployeeName(string employeeName)
        {
            this.EmployeeName = employeeName;
        }

        public double GetWagePerHour()
        {
            return WagePerHour;
        }

        public void SetWagePerHour(double wagePerHour)
        {
            this.WagePerHour = wagePerHour;
        }

        public bool GetIsPresent()
        {
            return IsPresent;
        }

        public void SetIsPresent(bool isPresent)
        {
            this.IsPresent = isPresent;
        }

        public string GetEmployeeType()
        {
            return EmployeeType;
        }

        public void SetEmployeeType(string employeeType)
        {
            this.EmployeeType = employeeType.Trim();
        }

        public override string? ToString()
        {
            return "EmployeeName : " + EmployeeName +
                   " EmployeeId : " + EmployeeId +
                   " WagePerHour : " + WagePerHour +
                   " EmployeeIsPresent : " + IsPresent +
                   " EmployeeType : " + EmployeeType;
        }
    }
}
