using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana04
{
    public class Suco : Bebida
    {
        public string TipoCaixa { get; set; }
        
        public Suco(string tipoCaixa, int id, string tipo, decimal miliLitro, string nomeBebida, decimal valorDaCompra) : base(id, tipo, miliLitro, nomeBebida, valorDaCompra)
        {
            TipoCaixa = tipoCaixa;
        }
        


        public void ImprimirDados(Suco suco)
        {
            Console.WriteLine($"O produto de id {Id} é um suco sabor {Tipo}, caixa tipo {TipoCaixa} com a quantidade de {MiliLitro} mililitros.");
        }
    }
}
