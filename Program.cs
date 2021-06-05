using System;
using System.Collections.Generic;

namespace Magic_Trixia
{
    class Program
    {
        static void Main(string[] args)
        {
            Item PergaminhoNilo = new Item("Pergaminho 1xp", 20, "Pergaminhos", "Para realizar discursos na taverna");
            Item VarinhaDragao = new Item("Varinha 3xp", 120, "Varinhas", "Capaz de combater inimigos com ate 3000OP de vida");
            Item GrifoAmazonas = new Item("Grifo 10xp", 500, "Animais mágicos", "Aumenta o dano de ataque em 10%");
            Item CapaVoo = new Item("Capa 1xp", 50, "Roupas", "Aumenta a defesa contra danos em 5%");
            Item Nimbus3000 = new Item("Nimbus 80xp", 250, "Vassouras", "Permite danos superiores");
            Item LivroTransfiguracao = new Item("Livro 7xp", 80, "Livros", "Permite o combate com bruxas");

            List<Item> Catalogo = new List<Item>
            {
                PergaminhoNilo,
                VarinhaDragao,
                GrifoAmazonas,
                CapaVoo,
                Nimbus3000,
                LivroTransfiguracao
            };

            Personagem Mardeus = new Personagem("Mardeus Avicena");

            Console.WriteLine("**************************************\nBem-vindos ao Magic Trixia\n**************************************");
            
            String OpcaoPrincipal = "";
            
            while (OpcaoPrincipal != "0")
            {
                Console.WriteLine("MENU PRINCIPAL\n1 - Acessar loja\n2 - Acessar perfil\n0 - Sair");
                OpcaoPrincipal = Console.ReadLine();
                Console.Clear();
                if (OpcaoPrincipal == "1")
                {
                    Console.WriteLine("LOJA");
                    Console.WriteLine("Este é o nosso catálogo\n----------------------------------------------------------------------------");
                    foreach (var elemento in Catalogo)
                    {
                        elemento.ImprimirItem();
                    }
                    Console.WriteLine("Escreva o nome do item que quer comprar");
                    String Escolha = Console.ReadLine();
                    Console.Clear();

                    foreach (var elemento in Catalogo)
                    {
                        if (Escolha == elemento.Nome)
                        {
                            Console.WriteLine("Você escolheu o seguinte item");
                            elemento.ImprimirItem();
                            Console.WriteLine("Pretende continuar a compra?\n1 - sim\n2 - não");
                            String ConfirmaCompra = Console.ReadLine();
                            Console.Clear();

                            if (ConfirmaCompra == "1")
                            {
                                if (Mardeus.QuantidadeDeDinheiro - elemento.Preco < 0)
                                {
                                    Console.WriteLine("Saldo -> {0}", Mardeus.QuantidadeDeDinheiro);
                                    Console.WriteLine("Você não tem dinheiro suficiente\n\nPressione qualquer tecla para voltar ao menu inicial");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                                else if (Mardeus.QuantidadeDeDinheiro - elemento.Preco >= 0)
                                {
                                    Mardeus.QuantidadeDeDinheiro = Mardeus.QuantidadeDeDinheiro - elemento.Preco;
                                    Mardeus.Inventario.Add(elemento);
                                    Console.WriteLine("Saldo -> {0}", Mardeus.QuantidadeDeDinheiro);
                                    Console.WriteLine("Parabéns, você acaba de adquirir {0}", elemento.Nome);
                                    Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                            }
                            else if (ConfirmaCompra == "2")
                            {
                                break;
                            }
                        }
                    }


                }
                else if (OpcaoPrincipal == "2")
                {
                    String EscolhaPerfil = "";
                    while (EscolhaPerfil != "0")
                    {
                        Console.WriteLine("Perfil de {0}\n1 - Saldo\n2 - Inventário\n0 - Menu principal", Mardeus.Nome);
                        EscolhaPerfil = Console.ReadLine();
                        Console.Clear();

                        if(EscolhaPerfil == "1")
                        {
                            Console.WriteLine("Saldo -> {0}", Mardeus.QuantidadeDeDinheiro);
                            Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior");
                            Console.ReadKey();
                            Console.Clear();
                        } else if(EscolhaPerfil == "2")
                        {
                            Mardeus.ImprimirInventario();
                            Console.WriteLine("Pressione qualquer tecla para voltar ao menu anterior");
                            Console.ReadKey();
                            Console.Clear();
                        } else if(EscolhaPerfil == "0")
                        {
                            break;
                        }
                    }
                }
            }
        }
    }
}
