using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.task3
{
    public class Calculator
    {
        public int firstNumber;
        public int secondNumber;
        public int result;

        public void SaveResult(int result)
        {
            this.result = result;
        }

        public int Summarize()
        {
            result = firstNumber + secondNumber;
            SaveResult(result);
            return result;
        }

        public int Subtract()
        {
            result = firstNumber - secondNumber;
            SaveResult(result);
            return result;
        }

        public int Multiply()
        {
            result = firstNumber * secondNumber;
            SaveResult(result);
            return result;
        }

        public int Divide()
        {
            result = firstNumber / secondNumber;
            SaveResult(result);
            return result;
        }
    }
}
