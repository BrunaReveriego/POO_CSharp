using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploServicoRest.Controllers
{
    public class ExemploController : ApiController
    {
        private List<Fornecedor> ObterFornecedores()
        {
            var lista = new List<Fornecedor>();
            lista.Add(new Fornecedor() { Id = 1, Nome = "Google", Email = "contato@google.com.br" });
            lista.Add(new Fornecedor() { Id = 2, Nome = "Microsoft", Email = "contato@microsoft.com.br" });
            return lista;
        }


        // GET api/<controller>
        public IEnumerable<Fornecedor> Get()
        {
            var lista = ObterFornecedores();
            return lista;

        }

        // GET api/<controller>/5
        public Fornecedor Get(int id)
        {
            var lista = ObterFornecedores();
            var fornecedor = lista.Where(m => m.Id == id).First();
            return fornecedor;
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}