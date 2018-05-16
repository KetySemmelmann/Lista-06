using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que peça 10 números inteiros, calcule e mostre a
quantidade de números pares e a quantidade de números ímpares.*/

           
            int[] num = new int[10];
            int par = 0;
            int impar = 0;

            for (int i = 0; i <= 9; i++)
            {
                Console.Write("Digite um número: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("");

            foreach(var numb in num )
            {
                if (numb % 2 == 0)
                {
                    Console.WriteLine(numb + "= PAR");
                    par++;
                    Console.WriteLine("");                    
                } 
                else
                {
                    Console.WriteLine(numb + "= ÍMPAR");
                    impar++;
                    Console.WriteLine("");
                }
            }

            
            Console.WriteLine("A quantidade de números pares é: {0}", par);
            Console.Write("A quantidade de números ímpares é: {0}", impar);

            Console.ReadKey();






        }
    }
}
