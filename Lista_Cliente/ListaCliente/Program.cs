using ListaCliente;
using static System.Console;
using static System.Convert;

// feito na sala com o professor

// 2 passo: criar os elementos da lista
// a lista tem: novo, inicio, aux, lista



Cliente novo = null, inicio = null, lista = null, aux = null;
int op = 0;
do
{
    WriteLine(@"Escolha uma das Opções abaixo
    1- Cadastra novo Cliente na lista.
    2- Consulta os clientes no Lista.
    3- Busca um cliente na lista.
    4- Salva ou carrega a lista em um arquivo.
    0- Para sair do App");
    op = ToInt32(ReadLine());
    switch (op)
    {
        case 1:
            // 3 cadastro e inserção na lista
            novo = new Cliente();

            WriteLine("Digite o ID do Cliente");
            novo.id = int.Parse(ReadLine());

            WriteLine("Digite o Nome do Cliente");
            novo.nome = ReadLine();

            Endereco end = new Endereco();
            WriteLine("Digite Logradouro (rua, avenida) do Cliente");
            //novo.endereco.logradouro = 
            end.logradouro = ReadLine();
            WriteLine("Digite Bairro  do Cliente");
            end.bairro = ReadLine();
            WriteLine("Digite o numero  do Cliente");
            end.numero = ReadLine();
            WriteLine("Digite o CEP  do Cliente");
            end.cep = ReadLine();
            novo.endereco = end;
            // os produtos vetores


            // 4 passo encadeamento da lista

            if (inicio == null)
            {
                inicio = novo;
                inicio.prox = null;
            }
            else
            {
                if (inicio.prox == null)
                {
                    lista = novo;
                    // lista.ant = inicio;
                    inicio.prox = lista;
                    lista.prox = null;
                }
                else
                {
                    lista.prox = novo;
                    //novo.ant = lista;
                    lista = novo;
                    lista.prox = null;
                }
            }

            break;

        case 2:
            // consulta lista completa
            aux = inicio;
            while (aux != null)
            {
                WriteLine($"Id do Cliente: {aux.id}");
                WriteLine($"Nome do Cliente: {aux.nome}");
                
                WriteLine($"Endereço do Cliente =======");
                WriteLine($"Logradouro (rua, avenida): {aux.endereco.logradouro}");
                WriteLine($"Bairro: {aux.endereco.bairro}");
                WriteLine($"Número: {aux.endereco.numero}");
                WriteLine($"CEP: {aux.endereco.cep}");
                
                // 5 recebe o proximo
                aux = aux.prox;
            }
            break;

        case 3:
            // Busca um cliente na lista
            aux = inicio;

            Console.WriteLine("Digite o nome para buscar na lista");
            string nome = Console.ReadLine();
            bool achou = false;


            // 10 percorrer a lista
            while (aux != null)
            {
                string nm = aux.nome.ToLower();
                nome = nome.ToLower();
                if (nm.Equals(nome))
                {
                    Console.WriteLine(aux.nome);
                    achou = true;
                    break;
                }
                else
                {
                    achou = false;
                }

                aux = aux.prox;
            }

            if (!achou)
            {
                Console.WriteLine("Nao achei nada ");
            }

            break;

        case 4:
            // Salva ou carrega uma lista de  cliente
            string path = @"C:\Users\Public\meuarquivo.txt";
            // vai ter 10 pontos extras para carregar do arquivo a lista


            using (StreamWriter sw = new StreamWriter(path))
            {
                aux = inicio;
                while (aux != null)
                {
                    sw.WriteLine($"{aux.id}");
                    sw.WriteLine($"{aux.nome}");
                    sw.WriteLine($"{aux.endereco.logradouro}");
                    sw.WriteLine($"{aux.endereco.bairro}");
                    sw.WriteLine($"{aux.endereco.numero}");
                    sw.WriteLine($"{aux.endereco.cep}");
                    sw.WriteLine($";");

                    // 5 recebe o proximo
                    aux = aux.prox;
                }
                
            }

            using (StreamReader sr = new StreamReader(path))
            {
                string linha;
                int cont = 0;
                while ((linha = sr.ReadLine()) != ";")
                {
                    switch (cont)
                    {
                        case 0:

                            break;
                        default:
                            break;
                    }
                    Console.WriteLine(linha);
                }

            }

            break;

        default:
            break;
    }

} while (op!=0);