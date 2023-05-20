
using Semana04;
using System.Linq;
//Menu.DisplayInicial();



var lista = new List<String>();

lista.Add("Marcelo");

lista.Add("Rafael");
lista.Add("Vanessa");
lista.Add("Bruno");

lista.Add("Rafael");
lista.Add("Rafael");

lista.Add("André");
lista.Add("Marcelo");
lista.Add("Bruno");

lista.Add("Lucas");



var encontrar = lista.Find(x => x == "Vanessa");
Console.WriteLine(encontrar);

var existe = lista.Exists(x => x == "Jamil");
Console.WriteLine(existe);


var onde = lista.Where(x => x == "Rafael").ToList();
onde.ForEach(x => Console.WriteLine(x));












/*var alunoRafael = lista.Find(x => x == "Rafael");


var alunos = lista.Where(x => x == "Rafael").ToList();
var existe = lista.Exists(x => x == "Rafael");
var naoExiste = lista.Exists(x => x == "Lucas");

Console.Write("");*/