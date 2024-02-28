// See https://aka.ms/new-console-template for more information
using Checkpoint01.Models;


Console.WriteLine("===> Sistema de Cadastro de Clientes e Conta Bancária<===\n\n");
Console.WriteLine("1 - Incluir");
Console.WriteLine("2 - Excluir");
Console.WriteLine("3 - Exibir");
Console.WriteLine("4 - Depositar ");
Console.WriteLine("5 - Sacar ");
Console.WriteLine("6 - Extrato ");
Console.WriteLine("7 - Sair");
Console.WriteLine("Escolha uma opção: ");

var opcaoEscolhida = Console.ReadLine();

int idCliente = 0;
var controle = true;

while (controle)
{
    switch (opcaoEscolhida)
    {
        case "1":
            Cliente cliente = new();

            idCliente++;

            Console.WriteLine("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            Console.WriteLine("Digite a idade do cliente: ");
            int idadeCliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o email do cliente: ");
            string emailCliente = Console.ReadLine();

            Console.WriteLine("Deseja criar conta (1 = corrente ou 2 = poupaça): ");
            int tipoConta = int.Parse(Console.ReadLine());

            if (tipoConta == 1)
            {
                ContaCorrente contaCorrente = new();

                Console.WriteLine("Digite a agencia: ");
                int agencia = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número: ");
                int numero = int.Parse(Console.ReadLine());

                contaCorrente.Saldo = 0;
                contaCorrente.ChequeEspecial = 0;
                contaCorrente.Agencia = agencia;
                contaCorrente.Numero = numero;

                cliente.ContaCliente = contaCorrente;

            }

            if (tipoConta == 2)
            {
                ContaPoupanca contaPoupanca = new();

                Console.WriteLine("Digite a agencia: ");
                int agencia = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o número: ");
                int numero = int.Parse(Console.ReadLine());

                contaPoupanca.Saldo = 0;
                contaPoupanca.Rentabilidade = 0;
                contaPoupanca.Agencia = agencia;
                contaPoupanca.Numero = numero;

                cliente.ContaCliente = contaPoupanca;
            }


            // Atribui os valores ao usuário
            cliente.Id = idCliente;
            cliente.Nome = nomeCliente;
            cliente.Idade = idadeCliente;
            cliente.Email = emailCliente;

            Console.WriteLine(cliente.ToString());


            break;

        case "2":
            break;

        case "7":
            Console.WriteLine("Obrigado por usar nosso programa. ");
            break;

    }
}