﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTÃO._4
{
    class Program
    {
        static void Main(string[] args)
        {
            n = 1
            P = 0
            I = 0
            while n <= 10:
              a = int(input())
              n = n + 1
              if a % 2 == 0:
                  a = P
                  P = P + 1
            else:
              a = I
              I = I + 1

            print("A qtd de números pares é: ", P)
            print("A qtd de números ímpares é: ", I)
        }
    }
}
