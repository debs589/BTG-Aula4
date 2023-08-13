using static System.Net.Mime.MediaTypeNames;

namespace BTG_aula4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie uma classe Calculadora com dois atributos, valor1 e valor2.
            //Crie 4 métodos de operação básica matemática desses dois valores.
            //Crie uma classe de teste com um menu para a pessoa selecionar qual operação deseja realizar.
            //Mostre o resultado na tela e pergunte se deseja realizar novo calculo.
            //Utilize o máximo do conteúdo aprendido até aqui.

            bool continuar = true;
            int opcao = 1;
            decimal resultado;

            while (continuar == true && (opcao == 1 || opcao == 2 || opcao == 3 || opcao == 4))
            {

                Calculadora calculadora = new Calculadora();
                Console.WriteLine("Digite a operação matemática que deseja fazer: ");
                Console.WriteLine("\n1 - Somar\n2 - Subtrair\n3 - Multiplicar\n4 - Dividir\n");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite o primeiro valor: ");
                calculadora.valor1 = decimal.Parse(Console.ReadLine());
                Console.WriteLine("\nDigite o segundo valor: ");
                calculadora.valor2 = decimal.Parse(Console.ReadLine());

                if(opcao == 1)
                {
                    resultado = calculadora.Somar();
                    calculadora.ImprimirResultado(resultado);
                }
                else if (opcao == 2)
                {
                    resultado = calculadora.Subtrair();
                    calculadora.ImprimirResultado(resultado);
                } 
                else if (opcao == 3)
                {
                    resultado = calculadora.Multiplicar();
                    calculadora.ImprimirResultado(resultado);
                } 
                else if (opcao == 4)
                {
                    resultado = calculadora.Dividir();
                    calculadora.ImprimirResultado(resultado);
                }

                Console.WriteLine("\nDeseja realizar um novo calculo?: 'sim' ou 'não'");
                string novoCalculo = Console.ReadLine();
                if (novoCalculo == "sim")
                {
                    continuar = true;
                } else
                {
                    continuar = false;
                }
                
            }

        }
    }
}