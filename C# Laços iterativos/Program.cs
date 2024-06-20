using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laços_iterativos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Laço de repetição For : Estruturas que repetem um bloco de código, determinado número de vezes

            //laço for
            for (int i = 1; i < 19; i++) // i++ vai ser incrementado até ser menor que 5 de 1 em 1
            {
              Console.WriteLine("Valor de i é "+i);
            }

            //Laço de repetição While:
            int contador = 3;      
            while (contador <10)
            {
               Console.WriteLine(contador);
               contador++;

               //Laço de repetição Do While:
               //Executa o bloco de código uma vez e depois verifica se a condição é verdadeira.
               //Se a condição for verdadeira, o bloco de código é executado novamente.
               double j = 10;
               do
               {
                  Console.WriteLine(j);
                  j = j* 1.5;
               } while (j < 100);

               //Laço de repetição Foreach:
               //Percorre todos os elementos de um conjunto.
               int[] conjunto = {1,2,3,4,5,6,};
               foreach (int numero in conjunto)
               {
                  Console.WriteLine("Esse elemento do conjunto tem valor " + numero + "! Somando esse valor a 10 temos " +(numero+10));
               }
            }
        } 
    }
}