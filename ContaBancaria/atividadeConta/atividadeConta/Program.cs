/*
Atividade Contas
data: 21/02 e 28/02
SUNAMITA SANTOS
*/

using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Intrinsics.X86;

Console.WriteLine("Ola aqui Vamos Acessar uma Conta");

/*
Cria uma classe que possui os seguintes atributos: Id, agencia, Nº da conta, nome
do proprietário, saldo.

Crie uma instância da conta, pedin ao usuário do sistema que informe os dados dos atributos;

Crie um método chamado depósito, esse método deve receber um parâmetro com o valor(valor acrescido
no saldo).No entanto, não pode acrescentar no saldo valores negativos.

Crie um método que realize o saque, esse método deve receber como parâmetro o valor. Obs.O saque não
poder ser negativo e nem maior do que o valor permitido.

Crie uma instância da conta, pedindo ao usuário do sistema que informe os dados dos atributos
*/


Conta conta = new Conta();

Console.WriteLine("Digite o Id: ");
conta.id = Console.ReadLine();

Console.WriteLine("Digite a Agência: ");
conta.agencia = Console.ReadLine();

Console.WriteLine("Digite Numero da Conta: ");
conta.numeroConta = Console.ReadLine();

Console.WriteLine("Digite o Nome do Proprietário: ");
conta.nomeProprietario = Console.ReadLine();

//

conta.saldo = 500.00;
Console.WriteLine($"Seu Saldo é: R${conta.saldo}");

//Deposito

Console.WriteLine("Digite o Valor do Deposito: ");
double valorDeposito = Convert.ToDouble(Console.ReadLine());

conta.Deposito(valorDeposito);       // chamando o método


//Saque

Console.WriteLine("Digite o Valor do Saque: ");
double saque = Convert.ToDouble(Console.ReadLine());

conta.Saque(saque);                 // estou chamando o metodo


//criar uma lista do tipo da classe e pedir para mostrar o atributos da Conta.

List<Conta> todasContas = new List<Conta>();

    foreach (Conta c in todasContas)
    {

    Console.WriteLine(c.saldo);
    Console.WriteLine(c.id);

    }

            