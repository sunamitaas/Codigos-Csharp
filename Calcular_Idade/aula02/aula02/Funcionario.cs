
using Microsoft.VisualBasic;

public class Funcionario
{
    public string nome;
    public string cpf;
    public string email;
    public string senha;
    public string sexo;
    public DateOnly dataNascimento;   //DataOnly data de nascimento é desse tipo.

    // Estrutura do Metodo (funcao)
    // O Metodo deve estar dentro da classe
    // para Puxar função eu coloco a variavel.metodo()   
    // Metodo void ele não retorna

    // static (não precisa de um objeto para ser chamado)

    public void CalcularIdade()      // receber o parametro ('tipo do parametro'  e 'variavel')
    {
        double idade = 0.0;

        DateTime dataAtual = DateTime.Now;
        int anoAtual = dataAtual.Year;
        int mesAtual = dataAtual.Month;
        int diaAtual = dataAtual.Day;

        // cálculo da idade
        idade = dataAtual.Year - dataNascimento.Year;

        if (dataAtual.Month < dataNascimento.Month)
        {
            idade -= 1;

        }
        else if (dataAtual.Month == dataNascimento.Month)
        {
            if (dataAtual.Day < dataNascimento.Day)
            {
                idade -= 1;
            }

        }

        Console.WriteLine($"A Idade de {nome} é {idade}");    // so imprimi na tela ele não retorna

    }

    // função para calcular dois numeros aleatorios
     public int Calcular(int n1, int n2)
    {
        int soma = n1 + n2;

        return soma;

    }

    // toda vez que eu uso retorno eu preciso especificar o tipo.
    // o return é: toda vez que eu chamar o metodo ele deve me retornar algo,
    // o uso do return vai fazer com que ele use a variavel retornada depois .

}



