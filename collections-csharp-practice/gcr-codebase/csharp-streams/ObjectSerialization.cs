using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Employee
{
    public int Id;
    public string Name;
    public string Department;
    public double Salary;
}

class ObjectSerialization
{
    static void Main()
    {
        string filePath = "employees.dat";

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Amit", Department = "IT", Salary = 50000 },
            new Employee { Id = 2, Name = "Neha", Department = "HR", Salary = 45000 },
            new Employee { Id = 3, Name = "Ravi", Department = "Finance", Salary = 60000 }
        };

        FileStream fs = new FileStream(filePath, FileMode.Create);
        BinaryFormatter formatter = new BinaryFormatter();
        formatter.Serialize(fs, employees);
        fs.Close();

        FileStream fsRead = new FileStream(filePath, FileMode.Open);
        List<Employee> loadedEmployees =
            (List<Employee>)formatter.Deserialize(fsRead);
        fsRead.Close();

        foreach (Employee emp in loadedEmployees)
        {
            Console.WriteLine(
                emp.Id + " " +
                emp.Name + " " +
                emp.Department + " " +
                emp.Salary
            );
        }
    }
}
