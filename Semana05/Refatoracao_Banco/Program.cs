
using System.Globalization;
using M1S3_SistemaBanco.Interfaces;
using M1S3_SistemaBanco.Model;
using M1S3_SistemaBanco.Services;

string opcao;
do{
  Console.WriteLine("Bem vindos ao Banco FULL STACK BANCK, escolha uma opção");
  Console.WriteLine("1 - Criar Conta ");
  Console.WriteLine("2 - Adicionar Transacao");
  Console.WriteLine("3 - Consultar Extrato");
  Console.WriteLine("4 - Sair");
  Console.WriteLine("5 - Exibir Clientes");
  opcao = Console.ReadLine(); 

  if(opcao == "1"){
    IClienteService clienteService = new ClienteService();
        clienteService.CriarConta();
  }
  else if (opcao == "5"){
    IClienteService clienteService = new ClienteService();
        clienteService.ExibirClientes();
  }
  else if (opcao == "2"){
    AdicionarTransacao();
  }
  else if (opcao == "3"){
      ExibirExtrato();
  }

  Console.WriteLine("Tecle Enter para continuar");
  Console.ReadLine();
} while(opcao != "4");
  void AdicionarTransacao()
  {
    IClienteService clienteService = new ClienteService();
    Console.WriteLine("Qual a conta?");
      int numeroConta = int.Parse(Console.ReadLine());

      Cliente contaCliente = clienteService.BuscarClientePorNumeroDeConta(numeroConta);

      if (contaCliente == null){
        Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
        return;
      }

      Console.WriteLine("Qual o valor da transação?" );
      double valor = double.Parse(Console.ReadLine());
      Transacao transacao = new Transacao(DateTime.Now, valor);

      contaCliente.Extrato.Add(transacao);

  }
void ExibirExtrato()
{
    IClienteService clienteService = new ClienteService();
    Console.WriteLine("Qual a conta?");
    int numeroConta = int.Parse(Console.ReadLine());

    Cliente contaCliente = clienteService.BuscarClientePorNumeroDeConta(numeroConta);

    if (contaCliente == null)
    {
        Console.WriteLine("Conta não cadastrada, favor cadastrar antes");
        return;
    }
    double saldo = 0;
    foreach (Transacao transacao in contaCliente.Extrato)
    {
        Console.WriteLine(" Data: " + transacao.Data + " Valor: " + transacao.Valor.ToString("C2", new CultureInfo("pt-BR")));
        saldo += transacao.Valor;
    }

    Console.WriteLine("Saldo = " + contaCliente.Saldo.ToString("C2", new CultureInfo("pt-BR")));

}
