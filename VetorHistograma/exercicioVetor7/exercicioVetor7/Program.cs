//Exercicio 7
// SUNAMITA SANTOS NASCIMENTO

Console.WriteLine("Codifique um algoritmo Histograma, que " +
                  "exiba um histograma da variação da temperatura durante a semana." +
                  "Por exemplo, se as temperaturas forem 19ºC, 21ºC, 25ºC, 22ºC, " +
                  "20ºC, 17ºC, 15ºC, de domingo a sábado, respectivamente, o algoritmo" +
                  "deverá exibir:");

int day = 7;
double medtempera = 0;


string[] dia = new string[day];
double[] temperatura = new double[day];


string[] diasSemana = { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };

for (int i = 0; i < day; i++)
{

    Console.WriteLine("Digite a Temperatura do dia " + diasSemana[i] + ": ");
    temperatura[i] = Convert.ToDouble(Console.ReadLine());

    dia[i] = diasSemana[i];

}


for (int i = 0; i < day; i++)
{
    Console.WriteLine(dia[i] + ": ");
    for (int j = 0; j < temperatura[i]; j++)
    {
        
        Console.Write("■");

    }
    Console.WriteLine();
}


Console.ReadKey();
