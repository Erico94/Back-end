// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("Seja bem vindo ao programa que vai ajudá-lo com a tabuada");

//Variable to save the user's input;
int numero;

//Infos to user;
Console.WriteLine("");
Console.WriteLine("Por favor insira um número inteiro para que o programa te de os resultados do 0 ao 10");
numero=int.Parse(Console.ReadLine());

//Block of code that will do the match:
for (int i=0; i<11; i++ ){
    Console.WriteLine(numero+" x "+i+" = "+ (numero*i));
    
}