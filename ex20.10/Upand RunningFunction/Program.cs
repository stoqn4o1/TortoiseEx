using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Upand_RunningFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Sum(20, 55));
        }
    
        static int Sum(int num1, int num2)
        {
            int sum = num1 + num2;
            return sum;
        }
    }
}
