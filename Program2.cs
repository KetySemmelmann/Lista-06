using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*A série de Fibonacci é formada pela seqüência 1,1,2,3,5,8,13,21,34,55,... Faça
um programa capaz de gerar a série até o n−ésimo termo.*/

            Console.WriteLine("Série de Fibonacci");
            Console.WriteLine("");
            
            Console.Write("Digite o n−ésimo termo que você quer ir: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] fib = new int[n];
            fib[0] = 1;
            int ant = 0;

            for (int i = 0; i <= (n - 1); i++)
            {
                if (i != (n - 1))
                {
                    fib[i + 1] = fib[i] + ant;
                }

                ant = fib[i];
            }

            Console.WriteLine("O n-ésimo termo é: {0}", fib[n - 1]);

            Console.ReadKey();



        }
    }
}
