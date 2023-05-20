// See https://aka.ms/new-console-template for more information

//Variables that will save value:
double baseT;
double altura;
double resultado;

//Value inputs:
Console.WriteLine("");
Console.WriteLine("Olá usuário, digite a base do triângulo.");
baseT=int.Parse(Console.ReadLine());
Console.WriteLine("Muito bem, agora preciso da altura dele.");
altura=int.Parse(Console.ReadLine());

//Calc:
resultado=(baseT*altura)/2;

//Result exhibition:
Console.WriteLine("");
Console.WriteLine("Perfeito. Aqui está a área do triângulo:");
Console.WriteLine("Área total: "+resultado);