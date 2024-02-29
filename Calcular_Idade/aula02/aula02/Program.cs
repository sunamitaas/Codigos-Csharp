/* 

Aula 02
Sunamita Santos

QUESTÃO 1 DA PROVA
Crie uma classe e crie três instancias para ela.

CLASSE - (modificador de acesso: Public, interno, protegido)
Uma Classe define os atributos para criar um objeto é a forma. classe com letra maiuscula sempre 
Classe - Especie
Atributo - Gênero

Metodo é uma Acão
o Metodo ´pode receber um parametro ()
Void é um retorno vazio
o Metodo tem tipo de retorno e parametros

*/

// CRIAR UM INSTANCIA (objeto) 
//Criando Instancia da Classe Funcionario

Funcionario funcionario1 = new Funcionario();


//1
funcionario1.nome = "Claudia";
funcionario1.cpf = "123.456.789.12";
funcionario1.email = "claudia@gmail.com";
funcionario1.senha = "123456";
funcionario1.sexo = "feminino";
funcionario1.dataNascimento = new DateOnly(2000, 01, 01);


//Mostrar
Console.WriteLine($"o Nome o 1º Funcionario é: {funcionario1.nome}");
funcionario1.CalcularIdade();

//Calcular dois numeros aleatorios
funcionario1.Calcular(20, 10);  // você tem que criar um objeto para chamar o metodo

