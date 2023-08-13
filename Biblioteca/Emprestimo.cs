using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Emprestimo
    {
        
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }

        public Pessoa Pessoa { get; set;}
        public Livro Livro { get; set;}

        public Emprestimo(Pessoa pessoa, Livro livro)
        {
            DataEmprestimo = DateTime.Now;
            DataDevolucao = DateTime.Now.AddDays(7);
            Pessoa = pessoa;
            Livro = livro;
        }
        public void EmprestarLivro()
        {
            Console.WriteLine($"ID Livro: {Livro.Id}" +
                              $"\nLivro: {Livro.Titulo}" +
                              $"\nAutor: {Livro.Autor}" +
                              $"\nAno Publicação: {Livro.AnoPublicacao}" +
                              $"\nCliente: {Pessoa.Nome} {Pessoa.Sobrenome}" +
                              $"\nCPF Cliente: {Pessoa.Cpf}" +
                              $"\nTelefone Cliente: {Pessoa.Telefone}" +
                              $"\nData do Empréstimo: {DataEmprestimo}" +
                              $"\nData de Devolução: {DataDevolucao}");
        }

        public void DevolverLivro()
        {
            if ( DateTime.Now > DataDevolucao)
            {
                Console.WriteLine("Livro entregue com atraso, cliente deverá pagar multa de R$ 15,00");
            } else
            {
                Console.WriteLine("Devolução feita com sucesso");
            }
            
        }
    }
}
