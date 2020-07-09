using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

	public class NumberManipulatorFile 
	{
		public NumberManipulatorFile()
		{


		}

		private int _number;

		public int NumberValue => _number;

		public void AddOne() => _number++;

		public int testproperty
		{
			get
			{
				return _number;
			}
			set { }
		}

		public void Test1()
		{
			int number = 0;
			_number = 0;
		}

		private void Test2(int test)
		{
			int _number = 0;
			test = 0;
		}
	}
}
