using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkCoreExample1
{
    public class EmployeeDTO : IDisposable
    {
        public List<Employee> GetAllEmployee()
        {
            List<Employee> allEmployees = new List<Employee>();
            using(var context=new EntityFrameworkContext())
            {
                allEmployees = context.Employee.ToList<Employee>();
            }
            return allEmployees;
        }
        public void Dispose()
        {
           // throw new NotImplementedException();
        }
    }
}
