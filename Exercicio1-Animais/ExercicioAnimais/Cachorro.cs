using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAnimais
{
	class Cachorro : Animal
	{
		public override void EmitirSom()
		{
			base.EmitirSom();
			Console.WriteLine("Au au");
		}
	}
}
