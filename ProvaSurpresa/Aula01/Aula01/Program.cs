// Provinha Surpresa
// Sunamita Santos



namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variaveis

            int op = 0;
            string nome = "";
            int quanti = 0;
            double priNota = 0;
            double segNota = 0;
            double media = 0;

            string nome2 = "";
            double nota2 = 0;
            double notamedia = 0;


            Console.WriteLine("Hello Suna, Hoje será Provinha Surpresa");


            do
            {
                
                Console.WriteLine("\nSelecione qual exercicio você gostaria de ver:");
                Console.WriteLine(" 1 - para exercicio das MEDIAS");
                Console.WriteLine(" 2 - para exercicio 2 ");
                Console.WriteLine(" 3 - para exercicio 3 ");
                Console.WriteLine(" 4 - para exercicio 4 ");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        Console.WriteLine("A média final de um aluno em uma determinada " +
                            "disciplina é calculada com base no número de atividades avaliativas " +
                            "aplicadas pelo professor. Construa um Programa que 'Calcule a Média do Aluno'" +
                            "Receba NOME, Receba duas notas. ");

                        // media igual 60

                        Console.WriteLine("\nVamos CALCULAR SUA MEDIA");
                        Console.WriteLine("\nQual é seu Nome?");
                        nome = Console.ReadLine();

                        Console.WriteLine("\nQual foi a sua Nota na Primeira Atividade?");
                        priNota = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("\nQual foi a sua Nota na Segunda Atividade?");
                        segNota = Convert.ToDouble(Console.ReadLine());

                        media = (priNota + segNota) / 2;

                        Console.WriteLine($"sua Media Foi: {media}"); 


                        if (media >= 60)
                        {
                            Console.WriteLine("\nAPROVADO");
                        }
                        else
                        {
                            Console.WriteLine("REPROVADO");
                        }

                        break;


                    case 2:  

                    Console.WriteLine("\nVamos CALCULAR SUA MEDIA");

                    Console.WriteLine("\nQual é seu Nome?");
                    nome2 = Console.ReadLine();

                    Console.WriteLine("\nQuantas notas deseja calcular?");
                    quanti = Convert.ToInt32(Console.ReadLine());

                    double totalNota = 0;

                    for (int i = 0; i < quanti; i++)
                    {
                        Console.WriteLine($"Qual a Sua {i+1}º Nota: ");
                        totalNota += Convert.ToInt32(Console.ReadLine());

                    }


                    // calculo

                    double mediaTotal = totalNota / quanti;

                    Console.WriteLine($"sua Media Foi: {mediaTotal}");

                        if (mediaTotal >= 60)
                        {
                            Console.WriteLine("Você foi Aprovado!");
                        }
                        else
                        {
                            Console.WriteLine("Você esta Reprovado");
                        }


                    break;

                    case 3:

                        //Usar Vetor


                        Console.WriteLine (" Posteriormente, leia o nome de um aluno, as notas " +
                            "obtidas em cada atividade, calcule e apresente a média e se o aluno foi " +
                            "ou não aprovado.");

                        //Variaveis

                        string nome3 = "";
                        int quantAtividade = 0;

                        int quanti3 = 0;
                        double [] pesoAtivid = new double[quantAtividade];
                        double [] notaAtivid2 = new double[quantAtividade];
                        string [] nomeAtividade = new string [0];


                        Console.WriteLine("\nQual é seu Nome?");
                        nome3 = Console.ReadLine();

                        Console.WriteLine("Ola Professor quantas atividades Deseja Cadastrar? ");
                        quantAtividade = Convert.ToInt32(Console.ReadLine());



                        for (int i = 0; i < quantAtividade; i++)
                        {
                            Console.WriteLine($"Nome da Atividade: ");
                            nomeAtividade[quantAtividade] = Console.ReadLine();

                            Console.WriteLine($"Qual o Peso da sua Atividade: ");
                            pesoAtivid[quantAtividade] = Convert.ToDouble(Console.ReadLine());

                            Console.WriteLine($"Qual o Peso da sua Atividade: ");
                            notaAtivid2[quantAtividade] = Convert.ToDouble(Console.ReadLine());

                        }

                        // calculo

                          Console.WriteLine($"Nome: {nomeAtividade} Peso: {pesoAtivid}");

                        break;

                    case 4:

                        int numero = 0;

                        Console.WriteLine("O fatorial de um número é a multiplicação...");

                        Console.WriteLine("Informe o numero");
                        numero = Convert.ToInt32(Console.ReadLine());

                        double resultado = 0;
                            
                        for (int i = numero; i > 1 ; i--)
                        {

                            resultado += i;

                        }


                        break;
                }

            }while (op != 0);
            



        }
    }
}