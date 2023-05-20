// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("Seja bem vindo ao programa que lhe trará a sequência de Fibonacci. Para iniciar basta dar um ENTER.");
Console.ReadLine();
int aux1=0;
int aux2=1;
int fibo;
Console.WriteLine(aux2);
for(int i=0;i<20;i++){
   fibo=aux1+aux2;
   Console.WriteLine(fibo);
   aux1=aux2;
   aux2=fibo;
}



