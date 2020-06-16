using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkExmp
{
	public class EmployeeContext : DbContext
	{
		private readonly string connection;

		public EmployeeContext(string connection) {
			this.connection = connection;
		}
		public DbSet<Employee> Emp { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql(connection);
		}

	
	}
}
