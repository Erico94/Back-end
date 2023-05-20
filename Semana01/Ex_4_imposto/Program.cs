// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("Imposto sobre folha de pagamento");

//Variable that will save the gross salary:
double salarioBruto;
//Variable that will calculate the discount:
double total;

//Insertion the gross salary value:
Console.WriteLine("Insira o valor de seu salário bruto, reais e centavos:");
salarioBruto=double.Parse(Console.ReadLine());

//Conditional block to find the discount amount:
if (salarioBruto>2500.00){
   total=(salarioBruto/100)*20;
   Console.WriteLine("Será descontado 20% de seu salário, valor do desconto: R$"+total);
}else if((salarioBruto<=2500.00) && (salarioBruto>1500.00)){
    total=(salarioBruto/100)*10;
    Console.WriteLine("Será descontado 10% de seu salário, valor do desconto: R$"+total);
}
else if((salarioBruto<=1500.00) && (salarioBruto> 900.00)){
   total=(salarioBruto/100)*5;
   Console.WriteLine("Será descontado 5 % de seu salário, valor do desconto: R$"+total);
}
else{
    Console.WriteLine("Não haverá cobrança de imposto sobre seu salário.");    
}
