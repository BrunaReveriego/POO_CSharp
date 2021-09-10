using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosGenericos

{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Trocar<int>(a, b);
            Console.WriteLine(a + " " + b);
 
            string x = "primeiro";
            string y = "segundo";

            Trocar<string>(x,  y);
            Console.WriteLine(x + " " + y);
            Console.ReadKey();
        }

        private static void Trocar<T>(T lhs,T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
