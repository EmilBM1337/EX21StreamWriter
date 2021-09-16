using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace EX21StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\emil41m5\Desktop\MyFile.txt"))
            {
                writer.Write("Dette bliver skrevet på en linje");
                writer.Write(".. og det her fortsætter på samme linje");
                writer.WriteLine(".. det her står på samme linje, men afsluttes med nyt linjeskift");
                writer.WriteLine("Forskellen på Write og WriteLine er altså om den bliver afsluttet med nyt linjeskift eller ej");
                writer.WriteLine("1");
                writer.WriteLine("2");
            }
        }
    }
}
