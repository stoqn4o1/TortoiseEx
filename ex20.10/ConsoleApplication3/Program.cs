﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numbsGenerator = new Random();

            int numb1 = numbsGenerator.Next(1,5);
            int numb2 = numbsGenerator.Next(1,3);

            Console.WriteLine($"What is {numb1} times {numb2}?");

            int answer = int.Parse(Console.ReadLine());

            

            Console.ReadKey();


        }
    }
}
