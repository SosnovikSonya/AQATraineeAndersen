using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.task3
{
    class Task3_Main
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Введите первое число: ");
            var numb1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            var numb2 = Int32.Parse(Console.ReadLine());

            var obj1 = new Calculator();
            obj1.firstNumber = numb1;
            obj1.secondNumber = numb2;

            Console.WriteLine(numb1.ToString() + "+" + numb2.ToString() + " = " + obj1.Summarize());
            Console.WriteLine(numb1.ToString() + "-" + numb2.ToString() + " = " + obj1.Subtract());
            Console.WriteLine(numb1.ToString() + "*" + numb2.ToString() + " = " + obj1.Multiply());
            Console.WriteLine(numb1.ToString() + "/" + numb2.ToString() + " = " + obj1.Divide());

            //2
            var obj2 = new StringMathCalculator();
            Console.WriteLine("Введите функцию (2+2, 5-3, 5*2, 5/2): ");
            var strFunc = Console.ReadLine();
            Console.WriteLine(strFunc + " = " + obj2.OperationFromString(strFunc));

            //3
            var obj3 = new StringLingvoCalculator();
            Console.WriteLine("Введите функцию (4+2): ");
            strFunc = Console.ReadLine();
            Console.WriteLine(strFunc + " = " + obj3.OperationFromString(strFunc));

            Console.ReadKey();
        }
    }
}
