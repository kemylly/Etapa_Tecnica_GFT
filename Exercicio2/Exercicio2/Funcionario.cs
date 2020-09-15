using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Funcionario:Pessoa
    {
		//construtores
		public Funcionario():base()
		{
			this.Salario_Inicial = 0;
			this.Percentual = 0;
			this.Salario_Total = 0;
		}

		public Funcionario(String nome, String rg, double salario_inicial, double percentual, double salario_total):base(nome, rg)
		{
			this.Salario_Inicial = salario_inicial;
			this.Percentual = percentual;
			this.Salario_Total = salario_total;
		}

		//propriedades
		private double salario_inicial;

		public double Salario_Inicial
		{
			get { return salario_inicial; }
			set { salario_inicial = value; }
		}

		private double percentual;

		public double Percentual
		{
			get { return percentual; }
			set { percentual = value; }
		}

		private double salario_total;

		public double Salario_Total
		{
			get { return salario_total; }
			set { salario_total = value; }
		}

		//metodos
		public void Exibirsalario()
		{
			this.Salario_Inicial = this.Salario_Inicial + this.Percentual;  //2017
			this.Percentual = this.Percentual * 2; //dobro para 2018  3%
			this.Salario_Inicial = this.Salario_Inicial + this.Percentual; //2018
			this.Percentual = this.Percentual * 2; //dobro para 2019 6%
			this.Salario_Inicial = this.Salario_Inicial + this.Percentual; //2019
			this.Percentual =this. Percentual * 2; //dobro para 2020 12 %
			this.Salario_Total = this.Salario_Inicial + this.Percentual;

			Console.WriteLine("Nome: " + this.Nome);
			Console.WriteLine("Rg: " + this.Rg);
			Console.WriteLine("Salario em 2020: " + this.Salario_Total);
		}
	}
}
