using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha entre par ou ímpar. Para ímpar digite 1 e para par digite 0");
            int opcao = int.Parse(Console.ReadLine());

            int count = opcao;

            while (count <= 20) 
            {
               Console.WriteLine(count);
                count += 2;
            }
            Console.ReadKey();
        }
    }
}
