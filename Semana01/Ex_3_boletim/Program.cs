// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("BOLETIM ESCOLAR:");

//Variables that wil save the notes:
double nota1;
double nota2;
double nota3;

//Variables that will calc the average:
double media;

//Note inputs:
Console.WriteLine("Digite a primeira nota:");
nota1=double.Parse(Console.ReadLine());
Console.WriteLine("Digite a segunda nota:");
nota2=double.Parse(Console.ReadLine());
Console.WriteLine("Digite a terceira nota:");
nota3=double.Parse(Console.ReadLine());

//Average calculation:
media=(nota1+nota2+nota3)/3;

//Verification if student was aproved, if wass to recuperation or reproved:
if (media>=6.0){
    Console.WriteLine("Aluno aprovado com média "+media+".");
} else if ((media< 6.0) && (media>= 5.0)){
    Console.WriteLine("Aluno em recuperação com média "+media+".");
}else{
    Console.WriteLine("Aluno reprovado com média "+media+".");
}
Console.WriteLine(" ");
Console.WriteLine(" ");
