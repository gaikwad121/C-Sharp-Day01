using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Pattern
{
	internal class Class12
	{
		int a;
		int b;
		public Class12(int a, int b)
		{
			this.a = a;
			this.b = b;
			twoswapNumWith3rd();
			twoSwapNumWithout3rdNum();
			twoSwapNumWithout3rdNum2();
		}
		public void twoswapNumWith3rd()
		{
			Console.WriteLine("Before swap " + a + "  " + b);

			int temp = a;
			a = b;
			b = temp;

			Console.WriteLine("after swap " + a + " " + b);
		}
		public void twoSwapNumWithout3rdNum()
		{
			Console.WriteLine("Before swap " + a + "  " + b);

			a = a * b;
			b = a / b;
			a = a / b;
			Console.WriteLine("after swap " + a + " " + b);
		}
		public void twoSwapNumWithout3rdNum2()
		{
			Console.WriteLine("before swap " + a + "  " + b);

			a = a + b;
			b = a - b;
			a = a - b;
			Console.WriteLine("After swap " + a +"  "+ b);

		}
	}
}
