using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	public class Human
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public uint Age { get; set; }

		/*
		//public List<Human> HumanList { get; set; }
		public Human()
		{
			this.HumanList = new List<Human>();
		}
		*/

		public Human(string lastName, string firstName, uint age)
		{
			Init(lastName, firstName, age);
            Console.WriteLine($"HumanConstructor: \t{GetHashCode()}");
        }

		public Human(Human other)
		{
			Init(other.LastName, other.FirstName, other.Age);
			Console.WriteLine($"HumanCopyConstructor: \t{GetHashCode()}");
		}

		~Human() {Console.WriteLine($"HumanDestructor: \t{GetHashCode()}");}

		void Init(string lastName, string firstName, uint age)
		{
			this.LastName=lastName;
			this.FirstName=firstName;
			this.Age = age;
		}

		public void Print()
		{
            Console.WriteLine($"{LastName} {FirstName} {Age}");
        }

		public override string ToString()
		{
			return base.ToString() + $": {LastName} {FirstName} {Age}";
		}
	}
}
