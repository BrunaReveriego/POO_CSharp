using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario(1);

            carlos.Nome = "Carlos";
            carlos.CPF = "123.456.789-10";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor bruna = new Diretor();
            bruna.Nome = "Bruna";
            bruna.CPF = "457.787.154-15";
            bruna.Salario = 5000;

            gerenciador.Registrar(bruna);

            Console.WriteLine(carlos.GetBonificacao());
            Console.ReadLine();


            Console.WriteLine(bruna.GetBonificacao());
            Console.ReadLine();

            Console.WriteLine("Total de bonificações: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();

        }
    }
}
