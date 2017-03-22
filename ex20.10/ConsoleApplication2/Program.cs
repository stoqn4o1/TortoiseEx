using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            string format = "dd-MM-yyyy";

            DateTime tdayslater = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
            tdayslater = tdayslater.AddDays(999);

            Console.WriteLine(tdayslater.ToString(format));
            Console.ReadLine();
                
        }
    }
}
