﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpITFizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)        // divisible by both 3 and 5 means divisible by 15
                {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0)  // divisible by 3
                {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0)  // divisible by 5
                {
                    Console.WriteLine("Buzz");
                } else                  //divisible by neither 3 nor 5
                {
                    Console.WriteLine(i);
                }
   
            }

            Console.WriteLine();      //whitespace
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}