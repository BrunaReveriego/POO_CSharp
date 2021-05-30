using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExemploServico
{
    // OBSERVAÇÃO: Você pode usar o comando "Renomear" no menu "Refatorar" para alterar o nome da classe "Servico01" no arquivo de código, svc e configuração ao mesmo tempo.
    // OBSERVAÇÃO: Para iniciar o cliente de teste do WCF para testar esse serviço, selecione Servico01.svc ou Servico01.svc.cs no Gerenciador de Soluções e inicie a depuração.
    public class Servico01 : IServico01
    {
        public string Mensagem()
        {
            return "Isso vem de um servidor usando WCF!";
        }

        public int Somar(int x, int y)
        {
            return x + y;
        }
    }
}
