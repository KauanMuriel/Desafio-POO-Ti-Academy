using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAnimais
{
	public abstract class Animal
	{
		public string Raca { get; set; }
		public double Tamanho { get; set; }

		public virtual void EmitirSom()
		{
			Console.WriteLine();
		}
		
	}
}
