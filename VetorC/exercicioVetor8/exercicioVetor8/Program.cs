//Exercicio 8
//SUNAMITA SANTOS NASCIMENTO



Console.WriteLine("Faça um algoritmo que construa dois vetores A e B de 10 elementos e, \n" +
                  "a partir deles, crie um vetor C, Composto pela soma dos elementos, sendo:\n" +
                  "* C[1] = A[1] + B[10], C[2] = A[2] + B[9], C[3] = A[3] + B[8], etc.\n");

// Variaveis Vetoriais

int elem = 10; //Tamanho
int[] A = new int[elem];
int[] B = new int[elem];
int[] C = new int[elem];

// Preenchendo os vetores A e B

for (int i = 0; i < elem; i++)
{
    Console.Write($"Digite o numero para  o Vetor A[{i + 1}]: ");
    A[i] = Convert.ToInt32(Console.ReadLine());

    Console.Write($"Digite o numero para o Vetor B[{i + 1}]: ");
    B[i] = Convert.ToInt32(Console.ReadLine());
}

// Construindo o vetor C pela soma dos elementos de A e B
for (int i = 0; i < elem; i++)
{
    C[i] = A[i] + B[elem - 1 - i];
}

//Mostrando o Vetor C:

Console.WriteLine("\nO Vetor C é: ");

for (int i = 0; i < elem; i++)
{
    Console.WriteLine($"C[{i + 1}] = {C[i]}"); // ele chama o Vetor C la do outro For.
}