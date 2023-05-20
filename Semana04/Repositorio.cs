using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Semana04
{
    public static class  Repositorio
    {
        public static List<Bebida> ListaBebida { get; set; }
        public static List<Suco> ListaSuco { get; set; }
        public static List<Refrigerante> ListaRefrigerante { get; set; }
          static Repositorio()
        {
            ListaBebida = new List<Bebida>();
            ListaSuco = new List<Suco>();
            ListaRefrigerante = new List<Refrigerante>();
        }

        public static void AdicionarSuco(Suco  suco )
        {
            Console.WriteLine("Adicionar suco. ");
            Console.WriteLine("Tamanho da caixa:");
            suco.TipoCaixa = Console.ReadLine();
            Console.WriteLine("Id:");
            suco.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo do suco:");
            suco.Tipo = Console.ReadLine();
            Console.WriteLine("Mililitros:");
            suco.MiliLitro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nome da bebida:");
            suco.NomeBebida = Console.ReadLine();
            Console.WriteLine("Valor:");
            suco.ValorDaCompra = decimal.Parse(Console.ReadLine());

            ListaSuco.Add(suco);
            Console.WriteLine($"Suco {suco.NomeBebida} adicionado.");
        }

        public static void AdicionarRefrigerante(Refrigerante refrigerante)
        {

            Console.WriteLine("Adicionar refrigerante. ");
            Console.WriteLine("Embalagem de vidro, digite true ou false:");
            refrigerante.Vidro = bool.Parse(Console.ReadLine());
            Console.WriteLine("Id:");
            refrigerante.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de refrigerante:");
            refrigerante.Tipo = Console.ReadLine();
            Console.WriteLine("Mililitros:");
            refrigerante.MiliLitro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Nome da bebida:");
            refrigerante.NomeBebida = Console.ReadLine();
            Console.WriteLine("Valor:");
            refrigerante.ValorDaCompra = decimal.Parse(Console.ReadLine());


            ListaRefrigerante.Add(refrigerante);
            Console.WriteLine($"Refrigerante {refrigerante.NomeBebida} adicionado.");

        }

        public static void AdicionarBebida(Bebida bebida)
        {
           
            Console.WriteLine("Adicionar bebida. ");
            Console.WriteLine("Digite o ID:");
            bebida.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o tipo de bebida:");
            bebida.Tipo = Console.ReadLine();
            Console.WriteLine("Quantidade em mililitros:");
            bebida.MiliLitro = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome da bebida:");
            bebida.NomeBebida = Console.ReadLine();
            Console.WriteLine("Valor (use vírgula para centavos):");
            bebida.ValorDaCompra = decimal.Parse(Console.ReadLine());

            ListaBebida.Add(bebida);
            Console.WriteLine($"Bebida {bebida.NomeBebida} adicionada.");
        }

        public static void AlterarBebida(Bebida bebida)
        {
            if (ListaBebida.Count > 0)
            {
                Console.WriteLine("Busque um Id:");
                int buscaPorId = int.Parse(Console.ReadLine());
                foreach (var item in ListaBebida)
                {
                    if (item.Id == buscaPorId)
                    {
                        ListaBebida.Remove(item);
                        Console.WriteLine("Alterar bebida");
                        bebida.Id = buscaPorId;
                        Console.WriteLine("Tipo:");
                        bebida.Tipo = Console.ReadLine();
                        Console.WriteLine("Mililitros:");
                        bebida.MiliLitro = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Nome da bebida:");
                        bebida.NomeBebida = Console.ReadLine();
                        Console.WriteLine("Valor da compra:");
                        bebida.ValorDaCompra = int.Parse(Console.ReadLine());

                        ListaBebida.Add(bebida);
                        Console.WriteLine("Bebida alterada com sucesso.");
                        Console.WriteLine("Tecle ENTER para retornar ao menu principal.");
                        Console.ReadLine();
                        Menu.DisplayInicial();

                    }
                    else { Console.WriteLine("ID não encontado."); }
                }
            }
            else { Console.WriteLine("Não contém itens na lista.");  }
        }

        public static void ExcluirBebida(Bebida bebida)
        {
            Console.WriteLine("Busque um Id:");
            int buscaPorId = int.Parse(Console.ReadLine());
            foreach(var item in ListaBebida)
            {
                if ( item.Id == buscaPorId)
                {
                    ListaBebida.Remove(bebida);
                    Console.WriteLine($"Bebida {item.NomeBebida},de id {item.Id} removida com sucesso.");
                    Console.WriteLine("Tecle ENTER para retornar ao menu principal.");
                    Console.ReadLine();
                    Menu.DisplayInicial();
                }
                else { Console.WriteLine("Não foi possível localizar o ID digitado."); }
            }

        }

        public static void ListarTodasBebidas(Bebida bebida)
        {
            
            foreach(var item in ListaBebida)
            {

                Console.WriteLine(" Id:"+item.Id+".");
                Console.WriteLine("-----------------------------------|");
                Console.WriteLine("Nome da bebida:" + item.NomeBebida+".");
                Console.WriteLine("-----------------------------------|");
                Console.WriteLine("Tipo:" + item.Tipo+".");
                Console.WriteLine("-----------------------------------|");
                Console.WriteLine("valor R$" + item.ValorDaCompra);
                Console.WriteLine("-----------------------------------|");
                Console.WriteLine("Miliitros: " + item.MiliLitro+"Ml");
                Console.WriteLine("-----------------------------------|");
                Console.WriteLine("");
                Console.WriteLine("");

            }
            Console.WriteLine("*****Fim*****");
            Console.WriteLine("Tecle ENTER para retornar ao menu principal.");
            Console.ReadLine();
            Menu.DisplayInicial();
        }

        public static void ListarTodosSucos(Suco suco)
        {
            foreach (var item in ListaSuco)
            {
                Console.WriteLine("Id:" + item.Id + ".");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Nome da bebida:" + item.NomeBebida + ".");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Tipo:" + item.Tipo + ".");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("valor R$" + item.ValorDaCompra);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Miliitros: " + item.MiliLitro + "Ml");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("");
                suco.ImprimirDados();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.WriteLine("*****Fim*****");
            Console.WriteLine("Tecle ENTER para retornar ao menu principal.");
            Console.ReadLine();
            Menu.DisplayInicial();
        }
        

        public static void ListarTodosRefrigerantes(Refrigerante refrigerante)
        {
            foreach (var item in ListaRefrigerante)
            {
                Console.WriteLine("Id:" + item.Id + ".");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Nome da bebida:" + item.NomeBebida + ".");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Tipo:" + item.Tipo + ".");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Mililitros: " + item.MiliLitro + "Ml");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Valor R$" + item.ValorDaCompra);
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("");
                refrigerante.ImprimirDados();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }
            Console.WriteLine("*****Fim*****");
            Console.WriteLine("Tecle ENTER para retornar ao menu principal.");
            Console.ReadLine();
            Menu.DisplayInicial();
        }

    }
}
