﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(1, 43)+" "+ rand.Next(1, 43)+" "+ rand.Next(1, 43)+" "+ rand.Next(1, 43)+" "+ rand.Next(1, 43)+" "+ rand.Next(1, 43));
            Console.ReadLine(); 
        }
    }
}
