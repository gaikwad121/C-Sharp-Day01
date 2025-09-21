using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	public  class Class8
	{
		int a;
		int b;
public Class8(int x,int y)
		{
			this.a = x;
			this.b = y;

		}
		public int add()
		{
			return a + b;
		}
		public int sub()
		{
			return a - b;
		}
		public int mul()
		{
			return a * b;
		}
		public int div()
		{
			return a / b;
		}
	}
}
