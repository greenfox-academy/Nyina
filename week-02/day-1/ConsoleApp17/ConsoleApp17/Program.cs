﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Give me 5 numbers");
            int[] numbers = new int[5];
            int inputNumber;


            for (int i = 0; i < numbers.Length; i++)
            {
                inputNumber = Convert.ToInt32(Console.ReadLine());
                numbers[i] += inputNumber;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine("Sum: " + sum);

            int average = sum / numbers.Length;
            Console.WriteLine("Average: " + average);
            Console.ReadLine();


            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
        }
    }
}
