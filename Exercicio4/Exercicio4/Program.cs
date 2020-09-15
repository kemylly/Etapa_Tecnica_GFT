using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Elefante f = new Elefante();

            Console.WriteLine("Digite um numero para o elefnate");
            f.Num = Convert.ToInt32(Console.ReadLine());

            f.ExibirElefante();
        }
    }
}
