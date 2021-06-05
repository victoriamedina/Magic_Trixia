using System;
using System.Collections.Generic;

namespace Magic_Trixia
{
    class Program
    {
        static void Main(string[] args)
        {
            // itens
            Item PergaminhoNilo = new Item
            {
                Nome = "Pergaminho 1xp",
                Preco = 20,
                Categoria = "Pergaminhos",
                BreveDescricao = "Para realizar discursos na taverna"
            };

            Item VarinhaDragao = new Item
            {
                Nome = "Varinha 3xp",
                Preco = 120,
                Categoria = "Varinhas",
                BreveDescricao = "Capaz de combater inimigos com ate 3000OP de vida"
            };

            Item GrifoAmazonas = new Item
            {
                Nome = "Grifo 10xp",
                Preco = 500,
                Categoria = "Animais mágicos",
                BreveDescricao = "Aumenta o dano de ataque em 10%"
            };

            Item CapaVoo = new Item
            {
                Nome = "Capa 1xp",
                Preco = 50,
                Categoria = "Roupas",
                BreveDescricao = "Aumenta a defesa contra danos em 5%"
            };

            Item Nimbus3000 = new Item
            {
                Nome = "Nimbus 80xp",
                Preco = 250,
                Categoria = "Vassouras",
                BreveDescricao = "Permite danos superiores"
            };

            Item LivroTransfiguracao = new Item
            {
                Nome = "Livro 7xp",
                Preco = 80,
                Categoria = "Livros",
                BreveDescricao = "Permite o combate com bruxas"
            };

            List<Item> Catalogo = new List<Item>
            {
                PergaminhoNilo,
                VarinhaDragao,
                GrifoAmazonas,
                CapaVoo,
                Nimbus3000,
                LivroTransfiguracao
            };

            Personagem Mardeus = new Personagem
            {
                Nome = "Mardeus Avicena",
                QuantidadeDeDinheiro = 500,
                Inventario = new List<Item>()
            };



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
                        Console.WriteLine("Nome: {0}", elemento.Nome);
                        Console.WriteLine("Nome: {0}", elemento.Preco);
                        Console.WriteLine("Nome: {0}", elemento.Categoria);
                        Console.WriteLine("Nome: {0}", elemento.BreveDescricao);
                        Console.WriteLine("----------------------------------------------------------------------------");
                    }
                    Console.WriteLine("Escreva o nome do item que quer comprar");
                    String Escolha = Console.ReadLine();
                    Console.Clear();

                    foreach (var elemento in Catalogo)
                    {
                        if (Escolha == elemento.Nome)
                        {
                            Console.WriteLine("Você escolheu o seguinte item");
                            Console.WriteLine("Nome: {0}", elemento.Nome);
                            Console.WriteLine("Nome: {0}", elemento.Preco);
                            Console.WriteLine("Nome: {0}", elemento.Categoria);
                            Console.WriteLine("Nome: {0}", elemento.BreveDescricao);
                            Console.WriteLine("----------------------------------------------------------------------------");
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
                            Console.WriteLine("Seu inventário possui:");
                            Console.WriteLine("----------------------------------------------------------------------------");

                            foreach (var elemento in Mardeus.Inventario)
                            {
                                Console.WriteLine("Nome: {0}", elemento.Nome);
                                Console.WriteLine("Nome: {0}", elemento.Preco);
                                Console.WriteLine("Nome: {0}", elemento.Categoria);
                                Console.WriteLine("Nome: {0}", elemento.BreveDescricao);
                                Console.WriteLine("----------------------------------------------------------------------------");
                                
                            }
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
