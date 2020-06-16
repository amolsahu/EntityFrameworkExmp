using System;

namespace EntityFrameworkExmp
{
    class Program
    {
        static void Main(string[] args)
        {
			var provider = new EmployeeProvider(new EmployeeContext("Host=localhost;Port=5432; Database = postgres; Username = postgres; Password = 1234"));
			var employee = provider.Get(1);
			Console.WriteLine("Id"+employee.empid+"employee name:" + employee.Name + " employee phone no:" + employee.phoneNo + "employee company:" + employee.Company);

        }
    }
}
