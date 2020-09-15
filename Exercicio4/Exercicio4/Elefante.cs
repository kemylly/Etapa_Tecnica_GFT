using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    public class Elefante
    {
		private int num;

		public int Num
		{
			get { return num; }
			set { num = value; }
		}

		//metodo
		public void ExibirElefante()
		{
			Console.WriteLine("Um elefente... ");
			int i = 0;
			while(i <= this.num)
			{
				Console.Write(" Incomoda ");
				i++;
			}
		}
	}
}
