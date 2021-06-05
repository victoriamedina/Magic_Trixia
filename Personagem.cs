using System;
using System.Collections.Generic;

namespace Magic_Trixia
{
	public class Personagem
	{
		public String Nome;
		public int QuantidadeDeDinheiro;
		public List<Item> Inventario;

		public Personagem(String Nome)
		{
			this.Nome = Nome;
			this.QuantidadeDeDinheiro = 500;
			this.Inventario = new List<Item>();
		}
		public void ImprimirInventario()
		{
			Console.WriteLine("Seu inventário possui:");
			Console.WriteLine("----------------------------------------------------------------------------");
			foreach (var elemento in this.Inventario) {
			Console.WriteLine("Nome:\t\t {0}", elemento.Nome);
			Console.WriteLine("Preco:\t\t {0}", elemento.Preco);
			Console.WriteLine("Categoria:\t {0}", elemento.Categoria);
			Console.WriteLine("Descricao:\t {0}", elemento.Descricao);
			Console.WriteLine("----------------------------------------------------------------------------");
			}
		}
	}
}