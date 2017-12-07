﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a path");
            string filename = Console.ReadLine();
            Console.WriteLine(CopyFile(filename, "NewFile.txt"));
            Console.ReadLine();
        }

        static bool CopyFile(string filename, string goalFile)
        {
            string[] lines = File.ReadAllLines(filename);
            File.WriteAllLines(goalFile, lines);
            return true;
        }

    }
}
