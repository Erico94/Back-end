using ConsoleApp1.Interfaces;
using ConsoleApp1.Services;

Console.WriteLine("Olá usuário, por favor digite o número da opção desejada.");
    string selecao;
 ITicketService ticketService = new TicketService();
    do
    {
        Console.WriteLine("Opções:");
        Console.WriteLine("1 - Cadastrar carro.");
        Console.WriteLine("2 - Marcar entrada.");
        Console.WriteLine("3 - Marcar saída.");
        Console.WriteLine("4 - Consultar histórico.");
        Console.WriteLine("5 - Sair.");
        selecao = Console.ReadLine();

        if (selecao == "1") 
        {
        ticketService.CadastrarCarro();
        }
        else if (selecao == "2") 
        {
        ticketService.GerarTicket();
        }
        else if (selecao == "3") 
        {
            ticketService.FecharTicket();
        }
        else if (selecao == "4")
        {
            ticketService.Historico();
        }
        else 
        {
        break;
        }
    } while (selecao != "5");



