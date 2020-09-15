using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            Console.WriteLine("Data do seu Aniversario");
            Console.WriteLine("*Digite apensas numeros*\n");

            Console.Write("Digite o dia: ");
            p.Dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o mes: ");
            p.Mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o ano: ");
            p.Ano = Convert.ToInt32(Console.ReadLine());

            p.ExibirValidade();  //exibir metodo

            Console.ReadKey();
        }
    }
}
