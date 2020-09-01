using System;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // вывод на экран
         /*
            multiline comments
         */
            var str = new string('=', 20);
            Console.WriteLine(str);
            //------------------------------------------------
            // вывод - вывод данных
            Console.Write("\n\tВведите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Как дела?");


            //------------------------------------------------


            
            Console.WriteLine(str);
            //------------------------------------------------ Numbers
            Console.WriteLine("\nEnter numbers");
            Console.Write("Enter number1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // divide

            if(num2==0)
            {
                Console.WriteLine("Divising by zero... ");
            }

            else
            {
                double result = (double)num1 / num2;
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
                Console.WriteLine("Result is " + result);
            }

            Console.Write("Press any key...");
            Console.ReadKey();


        }
    }
}
