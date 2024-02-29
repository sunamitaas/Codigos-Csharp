/*

Sunamita Santos Nascimento
Matrizes

*/

Console.WriteLine("Oi nesta lista vou apresentar meus exericios de matrizes espero que goste.\n");

int opcao = 0;

do
{
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - para o 1º exercicio");
    Console.WriteLine("2 - para o 2º exercicio");
    Console.WriteLine("0 - para sair"); 

    opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:

            Console.WriteLine("Faça um cadastro de alunos, onde cada aluno tem diferentes disciplinas e cada disciplina tem uma nota diferente.\n");

            string[] nomeAluno;
            int[] quantDiscipli;

            double[][] notas;
            string[][] disciplinas;

            Console.WriteLine("Quantos Alunos deseja cadastrar");
            int quant = Convert.ToInt32(Console.ReadLine());

            nomeAluno = new string[quant];
            quantDiscipli = new int[quant];

            notas = new double[quant][];
            disciplinas = new string[quant][];

            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Digite o nome do(a) Aluno(a)");
                nomeAluno[i] = Console.ReadLine();
                Console.WriteLine("Digite quantas Disciplinas o(a) aluno(a) esta cadastrado(a): ");
                quantDiscipli[i] = Convert.ToInt32(Console.ReadLine());
                notas[i] = new double[quantDiscipli[i]];
                disciplinas[i] = new string[quantDiscipli[i]];

                for (int j = 0; j < quantDiscipli[i]; j++)
                {
                    Console.WriteLine("Digite o nome da disciplina do(a) Aluno(a) " + nomeAluno[i]);
                    disciplinas[i][j] = Console.ReadLine();
                    Console.WriteLine("Digite a nota do(a) Aluno(a) " + nomeAluno[i]);
                    notas[i][j] = Convert.ToDouble(Console.ReadLine());

                }

            }

            // mostrar os dados

            Console.Clear();

            Console.Write("Carregando.");
            for (int i = 0; i < 60; i++)
            {
                System.Threading.Thread.Sleep(30);
                Console.Write(".");
            }

            Console.WriteLine("");
            for (int i = 0; i < quant; i++)
            {
                Console.WriteLine("Aluno(a): " + nomeAluno[i]);
                Console.WriteLine("Aluno(a) esta cadastrado(a) em " + quantDiscipli[i] + " disciplinas");

                for (int j = 0; j < quantDiscipli[i]; j++)
                {
                    Console.WriteLine("A " + (j + 1) + "º disciplina é : " + disciplinas[i][j]);
                    Console.WriteLine("A " + (j + 1) + "º nota final é: " + notas[i][j]);

                }

            }


            break;

        case 2:

            Console.WriteLine("Faça um cadastro de fazendeiros, onde cada fazendeiro tem diferentes tipos de gado " +
                "(bezerro, novilha, garote, vaca, boi) e cada tipo tem valor e quantidade diferente;\n");

            string[] nomeFazend;
            int[] quantGado;

            double[][] valorGado;
            string[][] tipoGado;

            Console.WriteLine("Quantos Fazendeiros deseja cadastrar");
            int quantf = Convert.ToInt32(Console.ReadLine());

            nomeFazend = new string[quantf];
            quantGado = new int[quantf];

            valorGado = new double[quantf][];
            tipoGado = new string[quantf][];

            for (int i = 0; i < quantf; i++)
            {
                Console.WriteLine("Digite o nome do(a) Fazendeiro(a)");
                nomeFazend[i] = Console.ReadLine();

                Console.WriteLine("Digite a quantidade de Gado que possui: ");
                quantGado[i] = Convert.ToInt32(Console.ReadLine());
                valorGado[i] = new double[quantGado[i]];
                tipoGado[i] = new string[quantGado[i]];

                for (int j = 0; j < quantGado[i]; j++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Selecione o " + (j + 1) +"º Tipo de gado que o(a)" + nomeFazend[i] + "tem: ");
                    Console.WriteLine("1 - Bezerro ");
                    Console.WriteLine("2 - Novilha ");
                    Console.WriteLine("3 - Garote ");
                    Console.WriteLine("4 - Vaca ");
                    Console.WriteLine("5 - Boi ");
                    
                    int opcaogado = Convert.ToInt32(Console.ReadLine());

                    switch (opcaogado)
                    {
                        case 1:

                            tipoGado[i][j] = "Bezerro";
                            Console.WriteLine("Digite o Valor do BEZERRO: ");
                            valorGado[i][j] = Convert.ToDouble(Console.ReadLine());

                            break; 
                        case 2:

                            tipoGado[i][j] = "Novilha";
                            Console.WriteLine("Digite o Valor da NOVILHA: ");
                            valorGado[i][j] = Convert.ToDouble(Console.ReadLine());

                            break;
                        case 3:

                            tipoGado[i][j] = "Garote";
                            Console.WriteLine("Digite o Valor do GARROTE: ");
                            valorGado[i][j] = Convert.ToDouble(Console.ReadLine());

                            break;
                        case 4:

                            tipoGado[i][j] = "Vaca";
                            Console.WriteLine("Digite o Valor da VACA: ");
                            valorGado[i][j] = Convert.ToDouble(Console.ReadLine());

                            break;
                        case 5:

                            tipoGado[i][j] = "Boi";
                            Console.WriteLine("Digite o Valor do BOI: ");
                            valorGado[i][j] = Convert.ToDouble(Console.ReadLine());

                            break;

                    }

                }

            }

            // mostrar os dados

            Console.Clear();

            Console.Write("Carregando.");
            for (int i = 0; i < 60; i++)
            {
                System.Threading.Thread.Sleep(30);
                Console.Write(".");
            }

            Console.WriteLine("");
            for (int i = 0; i < quantf; i++)
            {
                Console.WriteLine("Fazendeiro(a): " + nomeFazend[i]);
                Console.WriteLine("Quantidade de Gado que possui" + quantGado[i]);

                for (int j = 0; j < quantGado[i]; j++)
                {
                    Console.WriteLine("Tipo: " + tipoGado[i][j]);
                    Console.WriteLine("Valor Unitario: " + valorGado[i][j]);

                }

            }

            break;

        case 0:

            Console.WriteLine("Obrigada Saindo.");

            break;

        default:
            break;

    }

}while (opcao != 0);
