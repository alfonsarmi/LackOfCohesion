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

		public void SubtractOne() => _number--;

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

	public class NonCohesiveNumberManipulator
	{
		private int _firstNumber;
		private int _secondNumber;
		private int _thirdNumber;

		public void IncrementFirst() => _firstNumber++;
		public void IncrementSecond() => _secondNumber++;
		public void IncrementThird() => _thirdNumber++;
	}

}
