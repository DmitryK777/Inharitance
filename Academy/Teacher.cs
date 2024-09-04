using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academy
{
	public class Teacher:Human
	{
		public string Speciality { get; set; }
		int experince;

		public int Experince 
		{ 
			get => experince; 
			set => experince = value < 70 ? value: 70; 
		}

		public Teacher
			(
				string lastName, string firstName, uint age,
				string speciality, int experince
			):base(lastName, firstName, age)
		{
			Init(speciality, experince);
			Console.WriteLine($"TeacherConstructor: \t{GetHashCode()}");
        }

		public Teacher (Human human, string speciality, int experince):base(human)
		{
			Init(speciality, experince);
			Console.WriteLine($"TeacherConstructor: \t{GetHashCode()}");
		}

		public Teacher (Teacher other):base(other)
		{
			Init(other.Speciality, other.Experince);
		}
		~Teacher()
		{
			Console.WriteLine($"TeacherDestructor: \t{GetHashCode()}");
		}

		void Init(string speciality, int experince)
		{
			this.Speciality = speciality;
			this.Experince = experince;
		}

		public void Print()
		{
			base.Print();
			Console.WriteLine($"{Speciality} {Experince}");
		}

		public override string ToString()
		{
			return base.ToString() + $", {Speciality}, {Experince}";
		}

		
	}
}
