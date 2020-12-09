using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQATrainee.task4
{
    class Task4_Main
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

            Console.ReadKey();

        }
    }
}
