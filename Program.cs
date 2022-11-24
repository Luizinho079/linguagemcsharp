using System;

namespace EleiçãoWrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eleições 2022");
            int qtdCand26 = 0;
            int qtdCand44 = 0;
            int qtdCand56 = 0;
            int qtdNullo = 0;
            bool continuar = true;
            while (continuar)
                Console.WriteLine("Qual seu nome: ");
                string nome = Console.ReadLine();
                Console.Write("Vote em um dos candidatos a seguir: ");
                Console.Write("26 - João ");
                Console.Write("44 - Maria");
                Console.Write("56 - Tabet");
                Console.Write("0 - Nulo");
                Console.Write("Só digite o número");
            int meuVoto = Convert.ToInt32(Console.ReadLine() );
            
            if (meuVoto==26) { qtdCand26 = qtdCand26 + 1: }
            else if (meuVoto --44) { qtdCand44 = qtdCand44 + 1;
            else if (meuVoto --56) { qtdCand56 = qtdCand56 + 1:
            else qtdNullo = }
             
        }
    }
}
