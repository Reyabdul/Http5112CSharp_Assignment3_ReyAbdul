using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TeacherProject.Models
{
	public class Teacher
	{
		//The following properties define a Teacher
		public int TeacherId;
		public string TeacherFname;
		public string TeacherLname;
		public DateTime TeacherHireDate;
		public string TeacherSalary;
		public string CoursesTaught;

		//parameter-less constructor function
		public Teacher() { }
	}
}