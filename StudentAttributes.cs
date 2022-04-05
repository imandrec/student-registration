using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
	public class StudentAttributes
	{
		public int StudentId { get; set; }

		public string LastName { get; set; }

		public string FirstName { get; set; }

		public string Year { get; set; }

		public string Major { get; set; }

		public string Email { get; set; }

		public string[] Headers { get; internal set; }
	}
}
