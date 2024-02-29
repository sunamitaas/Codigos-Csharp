/*
Aula 11-09-2023
Sunamita Santos

*/

// Variaveis
double valor1 = 0;
double valor2 = 0;
double soma = 0;
double subtra = 0;
double multi = 0;
double dividi = 0;

string opera = "";


Console.WriteLine("Ola Vamos Calcular hoje: ");
Console.WriteLine("Digite o Primeiro Numero: ");
valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o Segundo Numero: ");
valor2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite a Operação: ");
opera = Console.ReadLine();

soma = Soma(valor1, valor2, opera);
subtra = Subtra(valor1, valor2, opera);
multi = Multi(valor1, valor2, opera);
dividi = Dividi(valor1, valor2, opera);

// funcoes
static double Soma(double x, double y, string opera)
{
    double resposta = 0;

    if (opera == "+")
    {  
        resposta = x + y;
    }
    return resposta;

}

static double Subtra(double x, double y, string opera)
{
    double resposta = 0;

    if (opera == "-")
    {
        resposta = x - y;
    }
    return resposta;

}

static double Multi(double x, double y, string opera)
{
    double resposta = 0;

    if (opera == "*")
    {
        resposta = x * y;
    }
    return resposta;

}

static double Dividi(double x, double y, string opera)
{
    double resposta = 0;

    if (opera == "/")
    {
        resposta = x / y;
    }
    return resposta;

}

// Mostrar resultado de acordo com a operação

if (opera == "+")
{
    Console.WriteLine($"O Resultado da Soma é: {soma}");
}

if (opera == "-")
{
    Console.WriteLine($"O Resultado da Soma é: {subtra}");
}

if (opera == "*")
{
    Console.WriteLine($"O Resultado da Soma é: {multi}");
}

if (opera == "/")
{
    Console.WriteLine($"O Resultado da Soma é: {dividi}");
}
