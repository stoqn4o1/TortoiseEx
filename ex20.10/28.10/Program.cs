using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._10
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int row = 1; row <= 10; row++)
            //{
            //    Console.WriteLine(new string('*', row ));
            //}

            //var today = Console.ReadLine();
            //string format = "dd-MM-yyyy";

            //DateTime tafter1000d = DateTime.ParseExact(today, format, CultureInfo.InvariantCulture);
            //tafter1000d = tafter1000d.AddDays(999);
            //Console.WriteLine(tafter1000d.ToString(format));
            //Console.ReadKey();

            Random NumGen = new Random();

            int num1 = NumGen.Next(1, 10);
            int num2 = NumGen.Next(1, 5);

            Console.WriteLine($"What is {num1} times {num2}");

            int answer = int.Parse(Console.ReadLine());
            int responce = NumGen.Next(1, 3);

            if (answer == num1*num2)
            {
                
                switch (responce)
                {
                    case 1:
                        Console.WriteLine("Correct!");
                        break;
                    case 2:
                        Console.WriteLine("Well done");
                        break;
                    default:
                        Console.WriteLine("kay...");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
            Console.ReadKey();
        }
    }
}
