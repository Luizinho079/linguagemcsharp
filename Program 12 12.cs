using System;

namespace ByteVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando vetor com 4 elementos estáticos.
            byte[] vbytes = { 2, 4, 8, 10 };

            Console.WriteLine("Listas de Valores do Vetor");
            Console.WriteLine("valor1: {0}", vbytes[0]);
            Console.WriteLine("valor2: {0}", vbytes[1]);
            Console.WriteLine("valor3: {0}", vbytes[2]);
            Console.WriteLine("valor4: {0}", vbytes[3]);
            Console.WriteLine("Total de elementos no vetor é {0}", vbytes.Length);

            for (int i = 0; i < vbytes.Length; i++)
            
                Console.WriteLine("Valor na posição {0} é igual a {1}",i, vbytes[i]);

            byte[] vbytesB = new byte[3];
            Console.WriteLine("Novos valores");
            for { int i = 0; i < vbytesB.Length; i++)

                    Console.WriteLine("Digite o {0} valor: ", i);

            try

            vbytesB[i] = Convert.ToByte(Console.ReadLine());

            catch(Exception)

              vbytesB[i] = 0;


            int contValidos= 0;
            int contInvalidos = 0;
            for (int i = 0; i < vbytesB.Length; i++)

                if (vbytesB[i] == 0) { contaInvalidados++; }
                else { contValidos++; }

            Console.WriteLine

        }
    }
}
