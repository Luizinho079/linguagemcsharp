using System;

namespace TipoByte
{
    class Program
    {
        static void Main(string[] args)
        {
            try


                byte x = Convert.ToByte(Console.ReadLine());
                Console.WriteLine("Os valores digitados são: {0}, x)", x);

            catch (OverFlowException)

               Console.WriteLine("O valor digitado esta fora o máximo. O máximo é 255");

            catch (FormaException)

               Console.WriteLine("Você digitou um texto. Só é aceitável um número de 0 a 255");
    }
}
