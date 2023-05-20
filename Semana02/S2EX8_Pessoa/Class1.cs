using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2EX08
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Pessoa (string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public void MostrarIdade()
        {
            
            Console.WriteLine($"Nome: {Nome} tem a idade de {CalcularIdade()} anos");
        }

        private int CalcularIdade()
        {
            
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;
            if (DataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            return idade;
        }
    }
}
