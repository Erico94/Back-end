using ConsoleApp1.Interfaces;
using ConsoleApp1.Model;

namespace ConsoleApp1.Services
{
    public class TicketService : ITicketService
    {
        List<Carro> CarroCadastrado = new List<Carro>();

        public TicketService() 
        {
        
        }
        public void CadastrarCarro()
        {
            Carro carro = ObterCarro();
            if (carro != null)
            {
                Console.WriteLine("Carro já cadastrado.");
                Console.ReadLine();
            }
            else
            {

                Carro novoCarro = new Carro();


                Console.WriteLine("Não é cadastrado.Tecle enter para continuar.");
                Console.ReadLine();
                Console.WriteLine("Digite a placa:");
                novoCarro.Placa = Console.ReadLine();

                Console.WriteLine("Digite o modelo:");
                novoCarro.Modelo = Console.ReadLine();

                Console.WriteLine("Digite a cor:");
                novoCarro.Cor = Console.ReadLine();

                Console.WriteLine("Digite a marca:");
                novoCarro.Marca = Console.ReadLine();

                CarroCadastrado.Add(novoCarro);

                Console.WriteLine("Veículo cadastrado com sucesso!");
                Console.ReadLine();
            }
        }

        public Carro ObterCarro()
        {
            string placa;
            Console.WriteLine(" VERIFICAR CADASTRO.");
            Console.WriteLine("Digite placa:");
            placa = Console.ReadLine();

            foreach (var carroCadastrado in CarroCadastrado)
            {
                if (placa == carroCadastrado.Placa)
                {
                    return carroCadastrado;
                    
                }
                else { return null; }

            }
            return null;
        }

        public void GerarTicket()
        {
            Carro carro = ObterCarro();
            if (CarroCadastrado != null)
            {
                if (carro.TicketList.Count == 0)
                {
                    Ticket novoTicket = new Ticket();
                    novoTicket.Entrada = DateTime.Now;
                    novoTicket.Ativo = true;
                    carro.TicketList.Add(novoTicket);
                    Console.WriteLine("Ticket ativado com sucesso.");
                    Console.ReadLine();
                    return;
                }
                else

                    foreach (Ticket ticket in carro.TicketList)
                    {
                        if (ticket.Ativo == false)
                        {
                            ticket.Ativo = true;
                            ticket.Entrada = DateTime.Now;
                            Console.WriteLine("Ticket ativado com sucesso.");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Já existe um ticket ativo para este veículo.");
                            Console.ReadLine();
                            break;
                        }
                    }

            }
            else
            {
                string selecao;
                Console.WriteLine("Veículo não cadastrado.");
            }

        }

        public void Historico()
        {
            Carro carro = ObterCarro();
            if (carro != null)
            {
                foreach (Ticket ticket in carro.TicketList)
                {
                    if (ticket.Ativo == true)
                    {
                        Console.WriteLine("Possui ticket ativo, encerre-o e retorne para ver histórico");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        for (int i = 1; i <= carro.TicketList.Count; i++)
                        {
                            Console.WriteLine($"Entrada : {ticket.Entrada}");
                            Console.WriteLine($"Saída : {ticket.Saida}");
                            Console.WriteLine($"Valor total : R${ticket.CalcularValor( ticket)}");
                            Console.ReadLine();
                            break;
                        }
                    }
                }
            }
            else
            {
                string selecao;
                Console.WriteLine("Veículo não cadastrado.");
                Console.ReadLine();
            }
        }

        public void FecharTicket()
        {

            Carro carro = ObterCarro();
            if (carro != null)
            {
                foreach (Ticket ticket in carro.TicketList)
                {
                    if (ticket.Ativo == true)
                    {
                        ticket.Ativo = false;
                        ticket.Saida = DateTime.Now;
                        Console.WriteLine("Saída marcada.");
                        Console.ReadLine();
                        break;
                    }

                    else if (ticket.Ativo != true)
                    {
                        Console.WriteLine("Ticket inativo.");
                        Console.ReadLine();
                        break;
                    }
                }
            }
            else
            {
                string selecao;
                Console.WriteLine("Veículo não cadastrado");
                Console.ReadLine();
                return;
            }
        }
    }
}
