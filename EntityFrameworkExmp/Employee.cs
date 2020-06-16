using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityFrameworkExmp
{
	[Table("Employee")]
    public class Employee
    {
		[Key]
		[Column("empid")]
		public int empid { get; set; }
		[Column("name")]
		public string Name { get; set; }
		
		[Column("phoneNo")]
		public string  phoneNo { get; set; }
		[Column("Company")]
		public string Company { get; set; }


	}
}
