using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtshit
{
    class Program
    {
        static void Main(string[] args)
        {
            //var date = Console.ReadLine();
            //string format = "dd/MM/yyyy";

            //DateTime todayafter1000days = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            //todayafter1000days = todayafter1000days.AddDays(999);

            //Console.WriteLine(todayafter1000days.ToString(format));
            //Console.ReadKey();

            //for (int row = 1; row <= 10; row++)
            //{
            //    Console.WriteLine(new string('*', row));
            //}
            //Console.ReadLine();

            for (int i = 1; i < 12; i++)
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
