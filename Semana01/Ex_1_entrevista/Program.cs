// See https://aka.ms/new-console-template for more information

//Variables to save data:
string nome;
string sobrenome;
int idade;
string corfavorita;

//Data capture:
Console.WriteLine("Olá, tudo bem? Qual seu nome?");
nome=Console.ReadLine();
Console.WriteLine("Qual é o seu sobrenome?");
sobrenome=Console.ReadLine();
Console.WriteLine("Qual a sua idade?");
idade=int.Parse(Console.ReadLine());
Console.WriteLine("Qual a sua cor favorita?");
corfavorita=Console.ReadLine();

//Informations output:
Console.WriteLine("");
Console.WriteLine("Aqui estão as informações:");
Console.WriteLine("Nome do usuário: "+nome);
Console.WriteLine("Sobrenome: "+sobrenome);
Console.WriteLine("Idade: "+idade);
Console.WriteLine("Cor favorita: "+corfavorita);
