using System;
using System.Collections.Generic;

namespace EntityFrameworkCoreExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> allEmployee = null;
            using(var eDto=new EmployeeDTO())
            {
                allEmployee = eDto.GetAllEmployee();
            }
            foreach(var emp in allEmployee)
            {
                Console.WriteLine("EmpID, FirstName, LastName, Age, Email, Address, Department");
                Console.WriteLine(emp.EmpId + "," + emp.FirstName + "," + emp.LastName + "," + emp.Age + "," + emp.Email + "," + emp.Address + "," + emp.Department);

            }
            Console.ReadLine();
        }
    }
}
