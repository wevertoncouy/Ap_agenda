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
        public Contato(int codigo, string nome, string email, string telefone,
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

        private int contatoId;
        public int ContatoId { get; set; }

        private string nome;
        public string Nome { get; set; }

        private string email;
        public string Email { get; set; }

        private string telefone;
        public string Telefone { get; set; }

        private string rua;
        public string Rua { get; set; }

        private string bairro;
        public string Bairro { get; set; }

        private string cidade;
        public string Cidade { get; set; }

        private string estado;
        public string Estado { get; set; }

        private string cep;
        public string Cep { get; set; }
    }
}
