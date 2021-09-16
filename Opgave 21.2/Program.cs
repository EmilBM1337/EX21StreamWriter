using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Opgave_21._2
{
    class Program
    {
        static void SaveRandomNumbers(int a, string s)
        {
            Console.WriteLine(a);
            Console.WriteLine(s);
            using (StreamWriter writer = new StreamWriter(s))
            {
                Random rnd = new Random();

                for (int i = 0; i < a; i++)
                {
                    writer.WriteLine(rnd.Next(1, 7));
                }
            }
        }
        static void Main(string[] args)
        {
            SaveRandomNumbers(100, @"C:\Users\emil41m5\Desktop\RandomNumbers.txt");
        }
    }
}
