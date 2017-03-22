using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int row = 1; row <= 10; row++)
            //{
            //    Console.WriteLine(new string('*', row));
            //}


            var date = Console.ReadLine();
            string format = "dd-MM-yyyy";

            DateTime tdayslayer = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            tdayslayer = tdayslayer.AddDays(999);
            
           Console.WriteLine(tdayslayer.ToString(format));
           Console.ReadLine();
        }
    }
}
