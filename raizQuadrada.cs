using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para descobrir sua raiz quadrada aproximada");
            int nR = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= nR; i+=2)
            {
                nR -= i;
                count++;
            }

            Console.WriteLine("A raiz quadrada aproximada do número digitado é " + count);
            Console.ReadLine();
        }
    }
}