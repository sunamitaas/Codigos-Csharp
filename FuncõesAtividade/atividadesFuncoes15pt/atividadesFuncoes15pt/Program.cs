namespace atividadesFuncoes15pt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Atividade Funções
            Sunamita Santos Nascimento
            */

            int opcao = 0;

            

            do
            {

                Console.WriteLine("\nATIVIDADES - FUNÇÕES");
                Console.WriteLine("Olá escolha a atividade que você quer ver");
                Console.WriteLine("1 - Exercicio 1");
                Console.WriteLine("2 - Exercicio 2");
                Console.WriteLine("3 - Exercicio 3");
                Console.WriteLine("4 - Exercicio 4");
                Console.WriteLine("5 - Exercicio 9");
                Console.WriteLine("0 - Para SAIR\n");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            //01
                            Console.WriteLine("\nEscreva um algoritmo para ordenar três numeros fornecidos" +
                                "pelo usuario, ultilizando a passagem de parametros formais");

                            Console.WriteLine("Digite o 1º número: ");
                            double numer01 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o 2º número: ");
                            double numer02 = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o 3º número: ");
                            double numer03 = double.Parse(Console.ReadLine());

                            OrganizarNumeros(numer01, numer02, numer03);

                            Console.WriteLine("Números Digitados: {0}, {1}, {2}", numer01, numer02, numer03);

                        break;
                        }
                    case 2:
                        {
                            //02
                            Console.WriteLine("\nEscreva um algoritmo para: ");      

                            // variaveis

                            int[,] Matriz = null;
                            int[,] matrizOrgani;
                            int[] matrizPar;
                            int[] mMultiplo5;

                            int opcao02 = 0;

                            do
                            {

                                Console.WriteLine("\n1 - Preencher a matriz A");
                                Console.WriteLine("2 - Ordenar a matriz A");
                                Console.WriteLine("3 - Gerar uma matriz somente com os números pares da matriz A");
                                Console.WriteLine("4 - Gerar uma matriz somente com os números múltiplos de 5 da matriz A");
                                Console.WriteLine("5 - Sair");

                                opcao02 = LerOpcao();

                                switch (opcao02)
                                {
                                    case 1:

                                        Matriz = PreencherMatriz();
                                        MosMatriz(Matriz, "\n Matriz A: ");

                                        break;

                                    case 2:

                                        matrizOrgani = OrganizaMatriz(Matriz);
                                        MosMatriz(matrizOrgani, "\n Matriz A Ordenada:  ");

                                        break;

                                    case 3:

                                        matrizPar = FiltroPar(Matriz);
                                        ImpriVetor(matrizPar, "\n Uma Matriz gerada so com os Números Pares da Matriz A: ");

                                        break;

                                    case 4:

                                        mMultiplo5 = FiltroMultiplo5(Matriz);
                                        ImpriVetor(mMultiplo5, "\n Uma Matriz gerada so com os Numeros Múltiplos de 5 da Matriz A: ");

                                        break;

                                    case 5:

                                        Console.WriteLine("\n Bye SAINDO...");

                                        break;
                                    default:

                                        Console.WriteLine("\n Opção inválida, Escolha uma opção válida.");

                                        break;
                                }
                            } while (opcao02 != 5);

                        break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nElabore um algoritmo que seja capaz de fazer a conversão de um" +
                                "valor em real, para o correspondente em dolar, libra, franco e iene e vice-versa." +
                                "\n O programa devera conter um menu com as opções e retornar os resultados para o programa" +
                                "principal, encarregado da exibição dos resultados.");

                            //variaveis

                            double real, dolar, libra, franco, iene;
                            int opcao03;

                            // Processamento

                            do
                            {

                                Console.WriteLine("\nEscolha uma opção:");
                                Console.WriteLine("1. Converter Real para Dólar");
                                Console.WriteLine("2. Converter Real para Libra");
                                Console.WriteLine("3. Converter Real para Franco");
                                Console.WriteLine("4. Converter Real para Iene");
                                Console.WriteLine("5. Sair");

                                opcao03 = int.Parse(Console.ReadLine());

                                switch (opcao03)
                                {
                                    case 1:

                                        dolar = RealDolar();
                                        Console.WriteLine($"Valor em Dólar: {dolar:F2}");

                                        break;
                                    case 2:

                                        libra = RealLibra();
                                        Console.WriteLine($"Valor em Libra: {libra:F2}");

                                        break;
                                    case 3:

                                        franco = RealFranco();
                                        Console.WriteLine($"Valor em Franco: {franco:F2}");

                                        break;
                                    case 4:

                                        iene = RealIene();
                                        Console.WriteLine($"Valor em Iene: {iene:F2}");

                                        break;
                                    case 5:

                                        Console.WriteLine("Bye, SAINDO");

                                        break;
                                    default:

                                        Console.WriteLine("Opção inválida");

                                        break;
                                }
                            } while (opcao03 != 5);

                        break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nConstrua um algoritmo que verifique se um dado numero é divisivel por outro," +
                                "sendo que ambos devem ser fornecidos pelo usuario, usando a passagem de parametros formais, com" +
                                "a exibição do resultado no programa principal.");

                            Console.WriteLine("Digite o 1º número: ");
                            double numero1 = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine("Digite o 2º número: ");
                            double numero2 = Convert.ToDouble(Console.ReadLine());

                            if (Dividido(numero1, numero2))
                            {
                                Console.WriteLine($"{numero1} é divisível por {numero2}.");
                            }
                            else
                            {
                                Console.WriteLine($"{numero1} não é divisível por {numero2}.");

                            }

                        break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nEscreva um função, para preencher um vetor, com 30 numeros inteiros sorteados" +
                                "aleatoriamente. O vetor deverá ser retornado ao programa principal, e você deve acrescentar:" +
                                "\n" +
                                "\n a) Um procedimento que recebe o vetor preenchido no item anterior, faz a ordenação" +
                                "dos elementos e apresenta o resultado através de uma mensagem exibida ao usuario." +
                                "\n b) Uma funcão que recebe o vetor preenchido no item a e que retorna a quantidade de numero " +
                                "multiplos de 7 que existem no conjunto." +
                                "\n c) Escreva o programa principal e faça a chamada aos métodos criados nos itens a, b e c.\n");


                            // PROGRAMA PRINCIPAL:
                            int[] vetor = NumAle();

                            Console.WriteLine("Vetor preenchido com 30 números aleatórios:");

                            PrintVetor(vetor);
                            OrdenarVetor(vetor);

                            Console.WriteLine("\nOrdenação dos Elementos do Vetor:");

                            PrintVetor(vetor);

                            int multiploSete = MultiplosSete(vetor);
                            Console.WriteLine($"\nQuantidade de numeros múltiplos de 7 do vetor: {multiploSete}");

                        break;
                        }
                }

            } while (opcao != 0);

            // FUNCOES ABAIXO:

            // 01
            static void OrganizarNumeros(double a, double b, double c)
            {
                double Orde;

                if (a > b)
                {
                    Orde = a;
                    a = b;
                    b = Orde;
                }
                if (b > c)
                {
                    Orde = b;
                    b = c;
                    c = Orde;
                }
                if (a > b)
                {
                    Orde = a;
                    a = b;
                    b = Orde;
                }

                Console.WriteLine("Números ordenados na função: {0}, {1}, {2}", a, b, c);
            }


            // 02
            static int LerOpcao()
            {
                //usada para ler a opção

                int opcao02 = 0;
                bool opcaoVal = false;

                do
                {
                    Console.Write("Escolha uma opção: ");
                    opcao02 = Convert.ToInt32(Console.ReadLine());

                    if (opcao02 >= 1 && opcao02 <= 5)
                    {
                        opcaoVal = true;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida");
                    }
                } while (!opcaoVal);  // continuara execultando enquando a opção não for valida.

                return opcao02;
            }

            static int[,] PreencherMatriz()
            {

                Console.Write("Digite o número de linhas da matriz: ");
                int linhas = Convert.ToInt32(Console.ReadLine());

                Console.Write("Digite o número de colunas da matriz: ");
                int colunas = Convert.ToInt32(Console.ReadLine());

                int[,] matriz = new int[linhas, colunas];

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        Console.Write($"Digite o Numero da posição [{i}, {j}]: ");
                        matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                return matriz;
            }


            static int[] FiltroPar(int[,] matriz)
            {
                int linhas = matriz.GetLength(0);
                int colunas = matriz.GetLength(1);
                int[] pares = new int[linhas * colunas]; // esta multiplicação vai determinar o tamanho do vetor par
                int contador = 0;

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (matriz[i, j] % 2 == 0)
                        {
                            pares[contador] = matriz[i, j];
                            contador++;
                        }
                    }
                }

                return pares;
            }

            static int[] FiltroMultiplo5(int[,] matriz)
            {
                int linhas = matriz.GetLength(0);
                int colunas = matriz.GetLength(1);
                int[] multiplosDe5 = new int[linhas * colunas];
                int contador = 0;

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        if (matriz[i, j] % 5 == 0)
                        {
                            multiplosDe5[contador] = matriz[i, j];
                            contador++;
                        }
                    }
                }

                return multiplosDe5;
            }

            static int[,] OrganizaMatriz(int[,] matriz)
            {
                int linhas = matriz.GetLength(0);
                int colunas = matriz.GetLength(1);
                int[] elementos = new int[linhas * colunas];
                int contador = 0;

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        elementos[contador] = matriz[i, j];
                        contador++;
                    }
                }

                contador = 0;
                int[,] matrizOrgani = new int[linhas, colunas];

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        matrizOrgani[i, j] = elementos[contador];
                        contador++;
                    }
                }

                return matrizOrgani;
            }


            static void MosMatriz(int[,] matriz, string nome)
            {
                Console.WriteLine($"{nome}:");

                int linhas = matriz.GetLength(0);
                int colunas = matriz.GetLength(1);

                for (int i = 0; i < linhas; i++)
                {
                    for (int j = 0; j < colunas; j++)
                    {
                        Console.Write(matriz[i, j] + "\t");  // "/t" criar espaçamento parecido com matriz, irá mostrar a matriz na sua estetica normal.
                    }
                    Console.WriteLine();
                }
            }


            static void ImpriVetor(int[] vetor, string nome)
            {
                Console.WriteLine($"{nome}:");
                foreach (int elemento in vetor)
                {
                    Console.Write(elemento + "\t");
                }
                Console.WriteLine();
            }


            //03
            // estas Taxas foram atualizadas de acordo com um site de intercambio da internet.
            static double RealDolar()
            {
                //variaveis
                // Taxa de conversão para Dólar 

                double real, dolar, resultado;

                Console.Write("Digite o valor em Real: ");
                real = Convert.ToDouble(Console.ReadLine());

                resultado = real * 0.20;
                dolar = resultado;

                return dolar;
            }

            static double RealLibra()
            {
                // Variaveis
                // Taxa de Conversão para Libra

                double real, libra;

                Console.Write("Digite o valor em Real: ");
                real = double.Parse(Console.ReadLine());

                libra = real * 0.16;

                return libra;
            }

            static double RealFranco()
            {
                // Variaveis
                // Taxa de Conversão para Franco

                double real, franco;

                Console.Write("Digite o valor em Real: ");
                real = double.Parse(Console.ReadLine());

                franco = real * 0.18; // Taxa de conversão para Franco

                return franco;

            }

            static double RealIene()
            {
                // Variaveis
                // Taxa de Conversão para Franco

                double real, iene;

                Console.Write("Digite o valor em Real: ");
                real = double.Parse(Console.ReadLine());

                iene = real * 29.94; // Taxa de conversão para Iene

                return iene;

            }



            //04
            static bool Dividido(double numero1, double numero2)
            {
                if (numero2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero.");
                    return false;
                }

                return numero1 % numero2 == 0;
            }


            //05 - NUMERO SORTEADOS - VETOR
            static int[] NumAle()
            {
                int[] vetor = new int[30];

                //obs.:
                // Random sort = new Random();
                // funcão para preencher um array com numeros aleatorios.

                Random numeAle = new Random();  

                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = numeAle.Next(1, 200); // vai gerar Números aleatórios de 1 a 200.

                }

                return vetor;
            }

            // 05 
            static void PrintVetor(int[] vetor)
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    Console.Write(vetor[i] + " ");
                }
                Console.WriteLine();
            }


            // 05
            static void OrdenarVetor(int[] vetor)
            {
                for (int i = 0; i < vetor.Length - 1; i++)
                {
                    for (int j = i + 1; j < vetor.Length; j++)
                    {
                        if (vetor[i] > vetor[j])
                        {
                            int temp = vetor[i];
                            vetor[i] = vetor[j];
                            vetor[j] = temp;
                        }
                    }
                }
            }

            // 05
            static int MultiplosSete(int[] vetor)
            {
                int multiSete = 0;
                for (int i = 0; i < vetor.Length; i++)
                {
                    if (vetor[i] % 7 == 0)
                    {
                        multiSete++;
                    }
                }
                return multiSete;
            }



        }

    }
}