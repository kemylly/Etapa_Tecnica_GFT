using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    public class Teste
    {
		//construtores
		public Teste()
		{
			this.Lado = 0;
			this.Altura = 0;
			this.Largura = 0;
			this.r = 0;
		}

		public Teste(int lado, int altura, int largura, int r) //sobrecarga
		{
			this.Lado = lado;
			this.Altura = altura;
			this.Largura = largura;
			this.r = r;
		}


		//propriedades
		private int lado;

		public int Lado
		{
			get { return lado; }
			set { lado = value; }
		}

		private int largura;

		public int Largura
		{
			get { return largura; }
			set { largura = value; }
		}

		private int altura;

		public int Altura
		{
			get { return altura; }
			set { altura = value; }
		}

		private int r;

		public int R
		{
			get { return r; }
			set { r = value; }
		}

		//metodos
		public void Exibir()
		{

		}
	}
}
