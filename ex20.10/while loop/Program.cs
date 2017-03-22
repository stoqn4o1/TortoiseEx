using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random numGen = new Random();

            //int attempt = 0;
            //int numbOfAttempts = 0;

            //while (attempt != 6)
            //{
            //    attempt = numGen.Next(1, 7);
            //    Console.WriteLine($"You rolled a {attempt}!");
            //    numbOfAttempts++;
            //}

            //Console.WriteLine($"It took you {numbOfAttempts} attempts to roll a six.");
            //Console.ReadKey();

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(new string('*', i));
            //}

            //var date = Console.ReadLine();
            //string format = "dd/MM/yyyy";

            //DateTime dafter1000d = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            //dafter1000d = dafter1000d.AddDays(999);

            //Console.WriteLine(dafter1000d.ToString(format));
            //Console.ReadLine();

            for (int i = 1; i < 28; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

        }
    }
}
