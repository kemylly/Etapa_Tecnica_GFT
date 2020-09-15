using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    public class Pessoa
    {
		//construtores
		public Pessoa ()
		{
			this.Nome = "";
			this.Rg = "";
		}

		public Pessoa (String nome, String rg) //sobrecarga
		{
			this.Nome = nome;
			this.Rg = rg;
		}

		//propriedades
		private String nome;

		public String Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		private String rg;

		public String Rg
		{
			get { return rg; }
			set { rg = value; }
		}

	}
}
