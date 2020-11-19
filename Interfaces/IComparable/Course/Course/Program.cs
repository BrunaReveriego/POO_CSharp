using System;
using System.IO;
using System.Collections.Generic;


namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Curso_CSharp_OO\Interfaces\IComparable\in.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<string> list = new List<string>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(sr.ReadLine());
                    }
                    list.Sort();
                    foreach (string str in list)
                    {
                        Console.WriteLine(str);
                    }

                    Console.ReadLine();
                }

            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
