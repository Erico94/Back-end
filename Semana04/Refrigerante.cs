using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana04
{
    public class Refrigerante : Bebida
    {
        public bool Vidro { get; set; }
        public Refrigerante(bool vidro, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorDaCompra) : base(id, tipo, miliLitro, nomeBebida, valorDaCompra)
        {
            Vidro = vidro; 
        }
        public void ImprimirDados()
        {
            if (Vidro == true)
            {
                Console.WriteLine($"o produto com id {Id}, bebida {NomeBebida} e {MiliLitro} mililitros, é um vidro.");
            }
            else
            {
                Console.WriteLine($"o produto com id {Id}, bebida {NomeBebida} e {MiliLitro} mililitros, é uma garrafa pet.");
            }
        }

    }
}
