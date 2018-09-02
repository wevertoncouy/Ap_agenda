using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAgenda
{
   public class Contato
    {
        public Contato()
        {
            this.ContatoId = 0;
            this.Nome = "";
            this.Email = "";
            this.Telefone = "";
            this.Rua = "";
            this.Bairro = "";
            this.Cidade = "";
            this.Estado = "";
            this.Cep = "";
         
        }
        public Contato(int contatoId, string nome, string email, string telefone,
            string rua, string bairro, string cidade, string estado, string cep)
        {
            this.ContatoId = contatoId;
            this.Nome = nome;
            this.Email = email;
            this.Telefone = telefone;
            this.Rua = rua;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Cep = cep;
        }

       
        public int ContatoId { get; set; }

      
        public string Nome { get; set; }

        public string Email { get; set; }

     
        public string Telefone { get; set; }

       
        public string Rua { get; set; }

        
        public string Bairro { get; set; }

        
        public string Cidade { get; set; }

       
        public string Estado { get; set; }

        
        public string Cep { get; set; }
    }
}
