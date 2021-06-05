using System;

namespace Magic_Trixia
{
	public class Item
	{
		public String Nome;
		public int Preco;
		public String Categoria;
		public String Descricao;

		public Item(String Nome, int Preco, String Categoria, String Descricao)
		{
			this.Nome = Nome;
			this.Preco = Preco;
			this.Categoria = Categoria;
			this.Descricao = Descricao;

		}

		public void ImprimirItem()
		{
			Console.WriteLine("Nome:\t\t {0}", this.Nome);
			Console.WriteLine("Preco:\t\t {0}", this.Preco);
			Console.WriteLine("Categoria:\t {0}", this.Categoria);
			Console.WriteLine("Descricao:\t {0}", this.Descricao);
			Console.WriteLine("----------------------------------------------------------------------------");
		}

	}
}