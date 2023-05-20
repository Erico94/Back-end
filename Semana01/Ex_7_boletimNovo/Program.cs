// See https://aka.ms/new-console-template for more information

Console.WriteLine("");
Console.WriteLine("Olá caro usuário, insira o nome do aluno:");
string nome=Console.ReadLine();

Console.WriteLine("Insira abaixo a quantidade de notas que vc deseja calcular:");

//Variable that will receive and save the amount of notes:
int quantidade;
quantidade=int.Parse(Console.ReadLine());

Console.WriteLine("Muito bem, agora introduza as notas e de um ENTER após digitar cada uma delas.");

//Creating array:
double [] listaDeNotas = new double [quantidade];
double medianotas=0;


//Note inputs:
for(int i=0 ; i<quantidade;i++){
Console.WriteLine("Digite a nota "+(i+1));
listaDeNotas[i]=double.Parse(Console.ReadLine());
medianotas=medianotas+(listaDeNotas[i]);
}

//Note and name outputs:
Console.WriteLine("");
Console.WriteLine("Aluno: "+nome);
for(int i=0 ; i<quantidade;i++){
Console.WriteLine((i+1)+"° nota="+listaDeNotas[(i)]);
}

//Operation that says if was approved, reproved or in recuperation:
double mediatotal=medianotas/quantidade;
if (mediatotal>6){
        Console.WriteLine("Aluno "+nome+" aprovado com média: "+mediatotal);
}else if(mediatotal<6&&mediatotal>=5){
        Console.WriteLine("Aluno "+nome+" em recuperação com média: "+mediatotal);
}else{
        Console.WriteLine("Aluno "+nome+" reprovado com média: "+mediatotal);
}
Console.WriteLine("");









