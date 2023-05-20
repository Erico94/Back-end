using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2EX02
{
    internal class FichaInscricao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public bool MenorIdade { get; set; }

        public FichaInscricao(int id, string nome, DateTime dataNascimento, bool menorIdade)
        {
            Id = id;
            Nome = nome;
            DataNascimento = dataNascimento;
            MenorIdade = menorIdade;
        }   

        public void Printar()
        {
            Console.WriteLine($"Código {Id}, Nome {Nome}, data de nascimento {DataNascimento}, menor de idade : {MenorIdade}");
        }
    }
}
