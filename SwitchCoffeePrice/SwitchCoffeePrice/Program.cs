﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCoffeePrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter");
            int i, j, n;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= n; i++)
            {
                for (j = 1; j <= n-i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= 2*i-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
