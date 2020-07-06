﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    public class NumberManipulatorFile
    {
        private int _number;

        public int NumberValue => _number;

        public void AddOne() => _number++;

        public void SubtractOne() => _number--;
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
