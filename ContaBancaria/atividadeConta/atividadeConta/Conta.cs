
using System.Drawing;
using System.Runtime.Intrinsics.X86;

public class Conta
{

    public string id;
    public string agencia;
    public string numeroConta;
    public string nomeProprietario;
    public double saldo;

    //Crie um método chamado depósito, esse método deve receber um
    //parâmetro com o valor (valor acrescido no saldo). No entanto, não pode
    //acrescentar no saldo valores negativos.

    public double Deposito(double valorDeposito)
    {

        if (valorDeposito >= 1)
        {
            saldo = saldo + valorDeposito;     // ou saldo += valorDeposito;
            Console.WriteLine($"Seu saldo de Deposito é: {valorDeposito}");
            Console.WriteLine($"Seu saldo Final é: {saldo}");
        }
        else
        {
            Console.WriteLine("Não podemos depositar número Negativos");
        }

        return saldo;
    }

    // Crie um método que realize o saque, esse método deve receber como parâmetro o valor. Obs.O saque não
    // poder ser negativo e nem maior do que o valor permitido.

    public double Saque(double saque)
    {


        if (saque >= 1 && saque <= saldo)
        {
            saldo = saldo - saque;
            Console.WriteLine("Seu saque foi realizado com sucesso");
            Console.WriteLine($"Seu Saldo final é: {saldo}");
        }
        else
        {
            Console.WriteLine("Seu Saque não foi realizado");
        }

        return saldo;
    }

    
    //OUTRAS FORMAS DE FAZER 
    //Certo
    public double Exemplo01(double valorDeposito2)
    {
        if (valorDeposito2 >= 1)
        {
            saldo += valorDeposito2;
            
        }
        return saldo;
    }


    //Certo Tambem - se tiver 3 if então vai ter tres retornos.
    public double Exemplo02(double valorDeposito2)
    {
        if (valorDeposito2 >= 1)
        {
            saldo += valorDeposito2;
            return saldo;
        }
        else
        {
            return saldo;
        }

    }

}   