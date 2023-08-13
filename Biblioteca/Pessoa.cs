using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Pessoa
    {

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set;}
        public long Telefone { get; set; }

        public Pessoa(string nome, string sobrenome, string cpf, long telefone)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Cpf = cpf;
            Telefone = telefone;
        }
    }
}
