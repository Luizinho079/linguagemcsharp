﻿using System;

namespace ByteParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 valores");
            string[] valores = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite o {0} valor: ", i + 1);
                valores[1] = Console.ReadLine();
            }
            byte[] pares = new byte[10];
            byte[] impares = new byte[10];
            int qtderros = 0;
            int indicepar = 0;
            int indiceimpar = 0;
            for (int i = 0; i < valores.Length; i++)
            {
                try
                {
                    byte v = Convert.ToByte(valores)[1];

                    if (v % 2 == 0)
                    {
                        pares[indicepar] = v;
                        indicepar++;
                    }
                    else
                    {
                        impares[indiceimpar] = v;
                        indiceimpar++;
                    }
                }
                catch (Exception)
                {
                    qtderros++;
                }

            }
            //Imprimir lista dos pares
            Console.WriteLine("pares");
            for (int i = 0; i < 10; i++)
            {
                if (pares[i] != 0) { Console.WriteLine(pares[i]); }

            }
            //Imprimir lista dos impares
            Console.WriteLine("Impares");
            for (int i = 0; i < 10; i++)
            {
                if (impares[i] != 0) { Console.WriteLine(impares[i]); }
            }
            //Total final de erros
            Console.WriteLine("Quantidade de erros {0}", qtderros);
                
             
