using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guitar
{
    public class Guitarra
    {

        private static string Afinacao;
        static Guitarra()
        {
            Afinacao = "SOL";
        }


        private void TomAfinado()
        {
            Console.WriteLine($"A guitarra está com afinação em {Afinacao}");
        }
        public void Tocar()
        {
            TomAfinado();
            
        }

        public void Tocar(string afinacaoAtual)
        {
            Afinacao = afinacaoAtual;
            TomAfinado();
        }


    }
}
