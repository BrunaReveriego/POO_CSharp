using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExemploServico
{

    //Metadados da interface
    [ServiceContract]
    public interface IServico01
    {
        //coisas que serviço faz
        [OperationContract]
        string Mensagem();

        //coisas que serviço faz
        [OperationContract]
        int Somar(int x, int y);


    }
}
