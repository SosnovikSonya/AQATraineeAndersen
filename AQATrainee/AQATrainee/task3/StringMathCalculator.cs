using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.task3
{
    public class StringMathCalculator : Calculator
    {
        //"2+2"=4        
        public virtual string OperationFromString(string stringFunction)
        {
            string[] numbers;
            if (stringFunction.Contains('+'))
            {
                numbers = stringFunction.Split(new char[] { '+' });
                firstNumber = Int32.Parse(numbers[0]);
                secondNumber = Int32.Parse(numbers[1]);
                return Summarize().ToString();
            }
            else if (stringFunction.Contains('-'))
            {
                numbers = stringFunction.Split(new char[] { '-' });
                firstNumber = Int32.Parse(numbers[0]);
                secondNumber = Int32.Parse(numbers[1]);
                return Subtract().ToString();
            }
            else if (stringFunction.Contains('*'))
            {
                numbers = stringFunction.Split(new char[] { '*' });
                firstNumber = Int32.Parse(numbers[0]);
                secondNumber = Int32.Parse(numbers[1]);
                return Multiply().ToString();
            }
            else if (stringFunction.Contains('/'))
            {
                numbers = stringFunction.Split(new char[] { '/' });
                firstNumber = Int32.Parse(numbers[0]);
                secondNumber = Int32.Parse(numbers[1]);
                return Divide().ToString();
            }
            else return null;

        }
    }
}
