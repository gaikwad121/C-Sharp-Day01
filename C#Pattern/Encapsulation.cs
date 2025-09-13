using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Encapsulation
	{

		private int studentId;
		private string studentName;
		public int get()
		{
			return studentId;
		}

		public string getName()
		{
			return studentName;
		}
		public void set(int id,string name)
		{
			studentId = id;
			studentName = name;  

		}
	}
}
