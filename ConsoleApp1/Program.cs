﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            do
            {
                if (a == 3)
                {
                    break;
                }
                Console.WriteLine(a);
                a++;
            }
            while (a <= 10)
        }
    }
}
