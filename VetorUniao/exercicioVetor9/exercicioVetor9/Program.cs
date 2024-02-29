// Exercicio 9
// SUNAMITA SANTOS NASCIMENTO

Console.WriteLine("Elabore um algoritmo que crie dois vetores A e B de 10 elementos e, a partir dele\n" +
    "crie um vetor C, composto pela união dos elementos A e B, \n" +
    "exibindo o resultado\n");


//Variaveis

int[] a = { 10, 19, 30, 45, 59 };
int[] b = { 12, 30, 32, 46, 50 };
int[] c = new int[(2 * a.Length)];

// 1º for

for (int i = 0; i < a.Length; i++)
{
    c[i] = a[i];
}

bool verifica = false;
int psicao = a.Length;


// 2º For (com outro for)

for (int i = 0; i < b.Length; i++)
{
    verifica = false;
    for (int j = 0; j < b.Length; j++)
    {
        if (b[i] == a[j])
        {
            verifica = true;
            j = b.Length + 1;
        }
        else
        {
            verifica = false;
        }
    }

    if (verifica != true)
    {
        c[psicao] = b[i];
        psicao++;
    }
}


// 3º For

for (int i = 0; i < c.Length; i++)
{
    if (c[i] != 0)
    {
        Console.WriteLine(c[i]);
    }
}
