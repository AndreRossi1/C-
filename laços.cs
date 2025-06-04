using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacosIterativos
{
     class Program
    {
        static void Main(string[] args)
        {
               // Laços iterativos => estruturas que repetem um bloco de código, determinado numero de vezes

            // laços for
            for(int i=0; i<5; i++) // i++ significa que i será incrementado de 1 em 1
            {
                Console.WriteLine("Valor de i é " + i);
            }

            // while
            int contador = 3;
            while (contador < 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            // Do .. while
            // Execução garantida pelo menos uma vez! (executa o bloco primeiro depois faz o teste de condição)
            double j = 10;
            do
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100);

            // Foreach
            // Percorre todos os elementos de um conjunto
            int[] conjunto = { 1, 2, 3, 4 };
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse Elemento do conjunto tem valor " + numero + "! Somando esse valor a 10 temos " + (numero+10));
            }
        }
    }
}
