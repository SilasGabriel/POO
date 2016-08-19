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
            int[] soma = new int[30];
            int i;
            int j = 0;
            int maior;
            for (i = 0; i <= 29; i++)
            {
                Console.Write("Digite o " + (i + 1) + "° número da A1: ");
                a1[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < 29; i++)
            {
                if (a1[i + 1] > a1[i])
                {
                    soma[j]++;
                }
                else
                {
                    j++;
                }
            }
            maior = soma[0];
            for (j = 1; j <= 29; j++)
            {
                if (soma[j] > maior) maior = soma[j];
            }
            Console.Write("A maior sublista ordenada crescentemente tem tamanho " + (maior + 1)); //soma 1 pois a soma sempre começa em zero
            Console.ReadKey();
        }
    }
}
