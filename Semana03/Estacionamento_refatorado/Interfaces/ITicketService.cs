using ConsoleApp1.Model;

namespace ConsoleApp1.Interfaces
{
    public interface ITicketService
    {
        public void CadastrarCarro();
        public Carro ObterCarro();
        public void GerarTicket();
        public void Historico();
        public void FecharTicket();
    }
}
