using System;
using System.Collections.Generic;
using System.Linq;

namespace EntityFrameworkExmp
{
   public class EmployeeProvider: IEmployeeProvider
    {
		private readonly EmployeeContext employeeContext;

		public EmployeeProvider(EmployeeContext employeeContext) {
			this.employeeContext = employeeContext;
		}
		public Employee Get(int id) {
			

			return employeeContext.Emp.FirstOrDefault(e => e.empid == id);
		}
    }
}
