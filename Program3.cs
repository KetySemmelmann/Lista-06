using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa que calcule o fatorial de um número inteiro fornecido pelo
usuário. Ex.: 5!=5.4.3.2.1=120 */

            Console.Write("Digite qual fatorial deseja saber: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] f = new int[n];
            int rf = 1;
            int v = 1;

            //Montando o Array
            for (int i = 0; i <= (n - 1); i++)
            {
                if (i == 0)
                {
                    f[i] = n;
                }
                else
                {
                    f[i] = n - v;
                    v++;
                }
            }

            //Fatorial
            foreach (var x in f)
            {
                rf *= x;
            }

            Console.WriteLine("");
            Console.WriteLine("O fatorial do número selecionado é: {0}", rf);
            Console.ReadKey();

        }
    }
}
