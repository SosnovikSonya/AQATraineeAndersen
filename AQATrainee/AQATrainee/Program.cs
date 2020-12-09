using System;

namespace AQATrainee
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)�������� HelloWorld
            //2)�������� ������ ������������ ��� ������ �� ����������.
            var value = "Hello World!";
            Console.WriteLine(value);
            Console.ReadKey();

            //3)�������� ��������� ������� ��������� 'Hello World' 333 ���� � �������������� ���� ���������� �������� ��������� � C#

            var showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(value);
            }
        }

        static bool MainMenu(string value)
        {
            Console.Clear();
            Console.WriteLine("1 �������� for");
            Console.WriteLine("2 �������� foreach");
            Console.WriteLine("3 �������� do...while");
            Console.WriteLine("4 �������� while");
            Console.WriteLine("5 �����");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    For(value);
                    Console.ReadKey();
                    return true;

                case "2":
                    Console.Clear();
                    Foreach(value);
                    Console.ReadKey();
                    return true;

                case "3":
                    Console.Clear();
                    DoWhile(value);
                    Console.ReadKey();
                    return true;

                case "4":
                    Console.Clear();
                    While(value);
                    Console.ReadKey();
                    return true;

                case "5":
                    return false;

                default:
                    return true;
            }

        }

        static void For(string value) 
        {
            for (int i = 0; i < 333; i++)
            {
                Console.WriteLine(i + " " + value);
            }
        }

        static void Foreach(string value)
        {
            int[] numbers = new int[333];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i;
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number + " " + value);

            }
        }

        static void DoWhile(string value)
        {
            var i = 0;
            do
            {
                Console.WriteLine(i + " " + value);
                i++;
            } while (i != 333);

        }

        static void While(string value)
        {
            var i = 0;
            while (i != 333)
            {
                Console.WriteLine(i + " " + value);
                i++;
            }

        }
    }
}
