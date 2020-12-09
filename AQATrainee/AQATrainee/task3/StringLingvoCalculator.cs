using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.task3
{
    public class StringLingvoCalculator : StringMathCalculator
    {
        // "2+2" = "22"

        public override string OperationFromString(string stringFunction)
        {
            string[] numbers;
            numbers = stringFunction.Split(new char[] { '+' });
            var result = numbers[0] + numbers[1];
            return result;
        }

    }
}
