using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    public class Pessoa
    {
		//construtores
		public Pessoa ()
		{
			this.Dia = 0;
			this.Mes = 0;
			this.Ano = 0;
		}

		public Pessoa (int dia, int mes, int ano) //sobrecarga
		{
			this.Dia = dia;
			this.Mes = mes;
			this.Ano = ano;
		}

		//propriedades
		private int dia;

		public int Dia
		{
			get { return dia; }
			set { dia = value; }
		}

		private int mes;

		public int Mes
		{
			get { return mes; }
			set { mes = value; }
		}

		private int ano;

		public int Ano
		{
			get { return ano; }
			set { ano = value; }
		}

		//metodo
		public void ExibirValidade()
		{
			if ((dia > 31) || (mes > 12) || (ano > 2018))
			{
				Console.WriteLine("Data invalida");
			}
			else
			{
				Console.WriteLine("Data Valida"); 
			}
		}
	}
}
