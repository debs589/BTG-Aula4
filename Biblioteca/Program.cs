namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new("Debora", "Carvalho", "34562387933", 119453627456);
            Livro livro = new(503, "E O Vento Levou", "Margaret Mitchell", 1936);

            Emprestimo emprestimo = new(pessoa, livro);

           emprestimo.EmprestarLivro();
           emprestimo.DevolverLivro();
        }
    }
}