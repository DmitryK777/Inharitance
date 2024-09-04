using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate:Student
	{
		public string Subject { get; set; }
		public Graduate
			(
				string lastName, string firstName, uint age,
				string speciality, string group, double rating, double attendance,
				string subject
			):base(lastName, firstName, age, speciality, group, rating, attendance)
		{ 
			Subject = subject;
            Console.WriteLine($"GraduateConstructor: \t{GetHashCode()}");
        }

		public Graduate(Student student, string subject):base(student)
		{
			Subject = Subject;
			Console.WriteLine($"GraduateConstructor: \t{GetHashCode()}");
		}

		~Graduate()
		{
			Console.WriteLine($"GraduateDestructor: \t{GetHashCode()}");
		}

		public void Print()
		{
			base.Print();
			Console.WriteLine($"{Subject}");
		}

		public override string ToString()
		{
			return base.ToString() + $", {Subject}";
		}
	}
}
