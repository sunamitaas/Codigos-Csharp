// Exericio 02
// SUNAMITA SANTOS NASCIMENTO

Console.WriteLine("Determine em quantos dias desta semana a\n " +
    "temperatura esteve acima da media.");

// Entrada e Variaveis
int day = 7;
double medtempera = 0;

string[] dia = new string[day];
double[] temperatura = new double[day];
double[] media = new double[day];

for (int i = 0; i < day; i++)
{
    Console.WriteLine("Digite o DIA que deseja registrar esta temperatura: ");
    dia[i] = (Console.ReadLine());

    Console.WriteLine("Digite a Temperatura do dia: ");
    temperatura[i] = Convert.ToDouble(Console.ReadLine());
    medtempera += temperatura[i];
}

medtempera /= day;
int diasAcimaMedia = 0;

for (int i = 0; i < day; i++)
{
    if (temperatura[i] > medtempera)
        diasAcimaMedia++;
}

for (int i = 0; i < day; i++)
{
    Console.WriteLine(dia[i].ToUpper() + " = " + temperatura[i] + "ºC");
}

Console.WriteLine($"A temperatura média da semana foi: {medtempera}ºC");
Console.WriteLine($"A temperatura esteve acima da média em {diasAcimaMedia} dias.");

Console.ReadKey();