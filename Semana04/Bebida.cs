using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana04
{
    public class Bebida
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public decimal MiliLitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorDaCompra { get; set; }

        public Bebida(int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorDaCompra)
        {
            Id = id;
            Tipo = tipo;
            MiliLitro = miliLitro;
            NomeBebida = nomeBebida;
            ValorDaCompra = valorDaCompra;
        }

        public void Comprar()
        {
            Console.WriteLine($"Valor da compra do produto id {Id} alterado para R${ValorDaCompra}");
        }

        public void ImprimirDados()
        {
            Console.WriteLine($"O produto de id {Id} é uma bebida {Tipo}, de nome {NomeBebida} com a quantidade de {MiliLitro}ML.");
        }
    }
}

