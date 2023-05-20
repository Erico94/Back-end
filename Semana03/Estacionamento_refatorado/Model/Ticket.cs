namespace ConsoleApp1.Model
{
    public class Ticket
    {
        public DateTime Entrada { get; set; }
        public DateTime Saida { get; set; }
        public bool Ativo { get; set; }
        public Ticket(DateTime entrada, DateTime saida, bool ativo)
        {
            Entrada = entrada;
            Saida = saida;
            Ativo = ativo;
        }
        public Ticket()
        {

        }
        private double CalcularTempo(Ticket ticket)
        {

            var tempo = ticket.Saida - ticket.Entrada;
            return tempo.TotalMinutes;
        }

        public double CalcularValor(Ticket ticket)
        {
            double valorTotal = CalcularTempo(ticket) * 0.09;
            return valorTotal;
        }

    }
}
