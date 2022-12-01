using System;

namespace ExercicioAnimais
{
	class Program
	{
		static void Main(string[] args)
		{

			bool mainProgram = true;

			while (mainProgram == true)
			{
				Console.Clear();
				Console.WriteLine("Descubra o som dos animais!");
				Console.WriteLine();
				Console.WriteLine("1.Cachorro");
				Console.WriteLine("2.Gato");
				Console.WriteLine("3.Passaro");
				Console.WriteLine("4.Encerrar");

				int animalChoosen = Convert.ToInt32(Console.ReadLine());

				switch (animalChoosen)
				{
					case 1:
						Cachorro cachorro = new Cachorro();
						cachorro.Raca = "Yorkshire";
						cachorro.Tamanho = 0.5;
						cachorro.EmitirSom();
						break;
					case 2:
						Gato gato = new Gato();
						gato.Raca = "Maltês";
						gato.Tamanho = 0.2;
						gato.EmitirSom();
						break;
					case 3:
						Passaro passaro = new Passaro();
						passaro.Raca = "Canário";
						passaro.Tamanho = 0.08;
						passaro.EmitirSom();
						break;
					case 4:
						mainProgram = false;
						break;
				}

				Console.WriteLine("Aperte ENTER para continuar");
				Console.ReadLine();
			}

			Console.WriteLine("Obrigado por conhecer o som dos animais!");
		}
	}
}
