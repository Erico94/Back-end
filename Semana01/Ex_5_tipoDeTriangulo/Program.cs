// See https://aka.ms/new-console-template for more information
Console.WriteLine("");
Console.WriteLine("TIPO DE TRIÂNGULO");

//Variables to save data:
int lado1;
int lado2;
int lado3;

//Collecting data:
Console.WriteLine("Por favor digite a medida do primeiro lado:");
lado1=int.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida do segundo lado:");
lado2=int.Parse(Console.ReadLine());
Console.WriteLine("Digite a medida do terceiro lado:");
lado3=int.Parse(Console.ReadLine());

//verification if it's a triangle:
if (((lado1+lado2)>(lado3))&((lado3+lado2)>(lado1))&((lado3+lado1)>(lado2))){

//verification which triangle it is:
    if ((lado1==lado2)&&(lado1==lado3)&&(lado2==lado3)){
        Console.WriteLine("É um equilátero.");
    }
        else if((lado1==lado2)||(lado1==lado3)||(lado2==lado3)){
        Console.WriteLine("É um isósceles.");
    }   
        else if((lado1!=lado2)&&(lado1!=lado3)&&(lado3!=lado2)){
        Console.WriteLine("É um escaleno.");
    }
}else{
    Console.WriteLine("Não forma um triângulo. Programa encerrando...");

}