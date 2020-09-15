using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            f.Salario_Inicial = 1000; //em 2016
            f.Percentual = 0.015; //percentual inicial de aumento 2017 + 1.5% depois é 3% (p*2)
            //1000 + 0.015 2m 2017
            // 

            f.Exibirsalario();

            Console.ReadKey();
        }
    }
}
