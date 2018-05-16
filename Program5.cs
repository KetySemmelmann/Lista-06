using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que leia uma quantidade indeterminada de números
positivos e conte quantos deles estão nos seguintes intervalos: [0-25], [26-50],
[51-75] e [76-100]. A entrada de dados deverá terminar quando for lido um
número negativo.*/

            int n;
            int count0_25 = 0, count26_50 = 0, count51_75 = 0, count76_100 = 0;

            


            do
            {
                Console.WriteLine("Digite o número: ");
                n = Convert.ToInt16(Console.ReadLine());


                if (n > 0 && n <= 25)
                {
                    count0_25++;
                }
                else if (n >= 26 && n <= 50) 
                {
                    count26_50++;
                }
                else if (n >= 51 && n <=75)
                {
                    count51_75++;
                }
                else if (n >= 76 && n <= 100)
                {
                    count76_100++;
                }

                
            } while (n != 0 );

            Console.WriteLine("Count0_25: " + count0_25);
            Console.WriteLine("Count26_50: " + count26_50);
            Console.WriteLine("Count51_75: " + count51_75);
            Console.WriteLine("Count76_100: " + count76_100);

            Console.ReadKey();

        }
    }
}
