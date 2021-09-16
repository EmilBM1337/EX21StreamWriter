using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Opgave_21._2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\emil41m5\Desktop\MyFile2.txt"))
            {
                Random rnd = new Random();

                for (int i = 0; i < 100; i++)
                {
                    writer.WriteLine(rnd.Next(1, 7));
                }
            }
        }
    }
}
