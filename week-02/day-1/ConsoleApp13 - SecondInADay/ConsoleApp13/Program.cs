﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            int realDay = 24 * 60 * 60;
            int currentDay = currentHours * 3600 + currentMinutes * 60 + currentSeconds;
            Console.WriteLine(realDay - currentDay);
            Console.ReadLine();

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables
        }
    }
}
