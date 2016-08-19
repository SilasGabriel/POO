using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[30];
            int[] a2 = new int[30];
            int[] a3 = new int[60];
            int i;
            int j;
            int soma = 0;
            for (i = 0; i <= 29; i++)
            {
                Console.Write("Digite o " + (i + 1) + "° número da A1: ");
                a1[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i <= 29; i++)
            {
                Console.Write("Digite o " + (i + 1) + "° número da A2: ");
                a2[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Intersecção: ");
            for (i = 0; i <= 29; i++)
            {
                for (j = 0; j <= 29; j++)
                {
                    if (a1[i] == a2[j])
                    {
                        a3[soma] = a1[i];
                        soma++;
                    }
                }
            }
            for (i = 0; i < soma; i++)
            {
                Console.Write(a3[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
