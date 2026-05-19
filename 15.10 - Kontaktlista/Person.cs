using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactList
{
	internal class Person
	{
		public string Name { get; set; }
		public string TelephoneNumber { get; set; }

		public Person(string name, string telephoneNumber)
		{
			Name = name;
			TelephoneNumber = telephoneNumber;
		}
	}
}
