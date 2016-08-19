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
            int soma = 0;
            int i;
            int j;
            for (i = 0; i <= 29; i++)
            {
                Console.Write("Digite o " + (i + 1) + "° número da A1: ");
                a1[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("array: {");
            for (i = 0; i <= 29; i++)
            {
                if (i < 29) Console.Write(a1[i] + " ");
                else Console.Write(a1[i] + "} \ne os elementos da array diferentes são: ");
            }
            for (i = 0; i <= 29; i++)
            {
                if (i < 29)
                {
                    for (j = i + 1; j <= 29; j++)
                    {
                        if (a1[i] != a1[j]) soma++;
                    }
                }
                if (i == 1)
                {
                    if (a1[1] != a1[0]) soma++;
                }
                else
                {
                    for (j = i - 1; j >= 0; j--)
                    {
                        if (a1[i] != a1[j]) soma++;
                    }
                }
                if (soma == 29) Console.Write(a1[i] + " ");
                soma = 0;
            }
            Console.ReadKey();
        }
    }
}
