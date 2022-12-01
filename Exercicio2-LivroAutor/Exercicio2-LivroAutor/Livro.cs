using System.Collections.Generic;


namespace Exercicio2_LivroAutor
{
	class Livro
	{
		public string Nome { get; set; }
		public List<Autor> Autores = new List<Autor>();
	}
}
