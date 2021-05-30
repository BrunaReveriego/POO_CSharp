using System;

namespace MetodosGenericosIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            string maiorString = Maximo("Bruna", "Lucas");
            int maiorInteiro = Maximo(2, 99);
            double maiorDouble = Maximo(445.98, 98.65);

            Console.WriteLine("Maior String = {0} ", maiorString);
            Console.WriteLine("Maior Inteiro = {0} ", maiorInteiro);
            Console.WriteLine("Maior Double = {0} ", maiorDouble);
            Console.ReadKey();
        }

        static public T Maximo<T>(T valor1, T valor2) where T : IComparable
        {
            if (valor1.CompareTo(valor2) > 0) return valor1;
            return valor2;
        }

        //        Where T: struct, indica que o argumento deve ser um tipo de valor.

        //Where T: class, indica que T deve ser um tipo de referência.

        //Where T: new(), obriga que o tipo T tenha um construtor público sem parâmetros;

        //Where T: nomeClasse, indica que o argumento deve herdar ou ser desse tipo.

        //Where T: nomeInterface, o argumento deve implementar a interface indicada.

        //Where T1: T2, T1 indica que o argumento T1 deve ser igual ou herdar o tipo, também argumento do método, T2.

    }
}
