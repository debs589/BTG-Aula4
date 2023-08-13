using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioAtributo
{
    internal class DesafioAtributo
    {
        int a = 10;
        public static void Executar() {
            //Acessar variável 'a' dentro do método Executar SEM alterar a linha 9
            //Solução --> instanciar a classe DesafioAtributo para ter acesso ao atributo a
            DesafioAtributo desafioAtributo = new();
            Console.WriteLine(desafioAtributo.a);
        
        }
        
    }
}
