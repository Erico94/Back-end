using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S02EX06
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Categoria { get; set; }
        public Filme(string nomeFilme, string categoria)
        {
            NomeFilme = nomeFilme;
            Categoria = categoria;
        }

        public void Funcao()
        {
            Console.WriteLine($"Filme {NomeFilme}, categoria {Categoria}.");
        }
    }
}
