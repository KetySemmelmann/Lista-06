using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolva um programa que faça a tabuada de um número qualquer inteiro
que será digitado pelo usuário, mas a tabuada não deve necessariamente
iniciar em 1 e terminar em 10, o valor inicial e final devem ser informados
também pelo usuário*/

            Console.Write("Digite qual tabuada deseja saber: ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Começa por:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Termina em:");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int r = 0;

            Console.WriteLine("\n\nVou fazer a Tabuada de {0} começando por {1} e terminando em {2}", t, c, f);

            for (int i = c; i <= f; i++)
            {
                r = t * i;
                Console.WriteLine("{0} X {1} = {2}", t, i, r);
            }

            Console.ReadKey();

        }
    }
}
