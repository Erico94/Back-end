using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2EX03
{
    public class MensagemCelular
    {
        public int Telefone { get; set; }
        public string Mensagem { get; set; }

        public MensagemCelular(int telefone, string mensagem)
        {
            Telefone = telefone;
            Mensagem = mensagem;
        }

        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine($"Telefone {Telefone}, mensagem : {Mensagem}");
         
        }

        public void Executar()
        {
            Console.WriteLine("Método executado pelo console");
            EnviarMensagemAoTelefone();
        }
    }
}
