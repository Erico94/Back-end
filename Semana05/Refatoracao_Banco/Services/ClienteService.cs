using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M1S3_SistemaBanco.Model;
using M1S3_SistemaBanco.Interfaces;

namespace M1S3_SistemaBanco.Services 
{
    public class ClienteService : IClienteService
    {
        public static List<Cliente> clientes = new List<Cliente>();


        public void CriarConta()
        {

            string opcao;
            do
            {
                Console.WriteLine("--CRIAR CONTA--");
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1 - Criar conta pessoa física.");
                Console.WriteLine("2 - Criar conta pessoa jurídica");
                Console.WriteLine("3 - Sair");
                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    CriarContaPF();
                }
                else if (opcao == "2")
                {
                    CriarContaPJ();
                }
                else if (opcao == "3")
                {
                    //MenuPrincipal();
                }

                Console.WriteLine("Tecle Enter para continuar");
                Console.ReadLine();
            } while (opcao != "3");
        }
        public Cliente BuscarClientePorNumeroDeConta(int numeroConta)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.NumeroConta == numeroConta)
                {
                    return cliente;
                }
            }
            return null;
        }
        public void ExibirClientes()
        {
            Console.WriteLine("------------------------------------------------------ ");
            for (int i = 0; i < clientes.Count; i++)
            {
                clientes[i].ResumoCliente();
                Console.WriteLine("------------------------------------------------------ ");
            }
        }
        public void CriarContaPF()
        {
            ClientePF pessoafisica = new ClientePF();
            Console.WriteLine("Data de Nascimento do cliente:");
            pessoafisica.DataNascimento = DateTime.Parse(Console.ReadLine());
            if (!pessoafisica.EhMaior())
            {
                Console.WriteLine("não é possivel abrir a conta pois o CLiente é menor de idade");
                return;
            }
            Console.WriteLine("A idade do cliente é " + pessoafisica.Idade);
            Console.WriteLine("Nome do cliente:");
            pessoafisica.Nome = Console.ReadLine();
            Console.WriteLine("CPF do cliente:");
            pessoafisica.CPF = Console.ReadLine();
            Console.WriteLine("Endereco do cliente:");
            pessoafisica.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone do cliente:");
            pessoafisica.Telefone = Console.ReadLine();
            Console.WriteLine("Email do cliente:");
            pessoafisica.Email = Console.ReadLine();
            Console.WriteLine("Numero Da Conta");
            pessoafisica.NumeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de conta:");
            pessoafisica.TipoDeConta = Console.ReadLine();
            clientes.Add(pessoafisica);
        }
        public void CriarContaPJ()
        {
            ClientePJ pessoajuridica = new ClientePJ();
            Console.WriteLine("Razão social da empresa:");
            pessoajuridica.RazaoSocial = Console.ReadLine();
            Console.WriteLine("CNPJ da empresa:");
            pessoajuridica.CNPJ = Console.ReadLine();
            Console.WriteLine("Endereco da empresa:");
            pessoajuridica.Endereco = Console.ReadLine();
            Console.WriteLine("Telefone da empresa:");
            pessoajuridica.Telefone = Console.ReadLine();
            Console.WriteLine("Email da empresa:");
            pessoajuridica.Email = Console.ReadLine();
            Console.WriteLine("Numero Da Conta");
            pessoajuridica.NumeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Tipo da conta:");
            pessoajuridica.TipoDeConta = Console.ReadLine();
            Console.WriteLine("Data de inauguração:");
            pessoajuridica.DataInauguracao = DateTime.Parse(Console.ReadLine());
            clientes.Add(pessoajuridica);
        }
    }
}
