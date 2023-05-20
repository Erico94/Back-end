
 string selecao;
 double saldo=0;
 
 //loop MENU:
 do{ 
   Console.WriteLine("Bem vindo ao Banco Nacional Coqueiros, por favor digite a opção desejada: ");
      Console.WriteLine("1-Adicionar transação");
      Console.WriteLine("2-Consultar extrato");
      Console.WriteLine("3-Sair");
       selecao=Console.ReadLine();
       Console.WriteLine("Você selecionou "+selecao);
 }while (!(selecao=="1" || selecao=="2" || selecao=="3"));

 List <double> conta= new List<double>();
 double deposito;


//Money deposit to account:
   if (selecao=="1") {
      Console.WriteLine("Digite abaixo o valor que deseja depositar:");
      deposito=double.Parse(Console.ReadLine());
      conta.Add(deposito);
      } 
      
      //Account balance:
      else if (selecao== "2"){
      
      for (int i=0; i < (conta.Count); i++){
          Console.WriteLine("Depósito de R$:"+conta[i]);
          saldo=saldo+conta[i];
      }
      Console.WriteLine("Saldo atual= R$"+saldo);
 }
 //Leaving the bank system:
 else{
   Console.WriteLine("Muito obrigado por utulizar nosso sistema, até a próxima.");
 }