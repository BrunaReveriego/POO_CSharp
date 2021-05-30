﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Esse código foi gerado por uma ferramenta.
//
//     As alterações no arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRefWcf
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebRefWcf.IServico01")]
    public interface IServico01
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/Mensagem", ReplyAction="http://tempuri.org/IServico01/MensagemResponse")]
        string Mensagem();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/Mensagem", ReplyAction="http://tempuri.org/IServico01/MensagemResponse")]
        System.Threading.Tasks.Task<string> MensagemAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/Somar", ReplyAction="http://tempuri.org/IServico01/SomarResponse")]
        int Somar(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServico01/Somar", ReplyAction="http://tempuri.org/IServico01/SomarResponse")]
        System.Threading.Tasks.Task<int> SomarAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IServico01Channel : WebRefWcf.IServico01, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class Servico01Client : System.ServiceModel.ClientBase<WebRefWcf.IServico01>, WebRefWcf.IServico01
    {
        
        /// <summary>
        /// Implemente este método parcial para configurar o ponto de extremidade de serviço.
        /// </summary>
        /// <param name="serviceEndpoint">O ponto de extremidade a ser configurado</param>
        /// <param name="clientCredentials">As credenciais do cliente</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public Servico01Client() : 
                base(Servico01Client.GetDefaultBinding(), Servico01Client.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IServico01.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Servico01Client(EndpointConfiguration endpointConfiguration) : 
                base(Servico01Client.GetBindingForEndpoint(endpointConfiguration), Servico01Client.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Servico01Client(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(Servico01Client.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Servico01Client(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(Servico01Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public Servico01Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public string Mensagem()
        {
            return base.Channel.Mensagem();
        }
        
        public System.Threading.Tasks.Task<string> MensagemAsync()
        {
            return base.Channel.MensagemAsync();
        }
        
        public int Somar(int x, int y)
        {
            return base.Channel.Somar(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SomarAsync(int x, int y)
        {
            return base.Channel.SomarAsync(x, y);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServico01))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IServico01))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:59575/Servico01.svc");
            }
            throw new System.InvalidOperationException(string.Format("Não foi possível encontrar o ponto de extremidade com o nome \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return Servico01Client.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IServico01);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return Servico01Client.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IServico01);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IServico01,
        }
    }
}
