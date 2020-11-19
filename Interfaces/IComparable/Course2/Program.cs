using System;
using System.IO;
using System.Collections.Generic;
using Course2.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Curso_CSharp_OO\Interfaces\IComparable\in2.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (Employee emp in list)
                    {
                        Console.WriteLine(emp);
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
