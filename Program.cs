


// //=================================================================
// //            VARIAVEIS DECLARADAS PARA COLETA DE DADOS DO USUARIO
// //=================================================================
string nome; // variavel que recebe um dado do tipo string.
int idade; // variavel que recebe um dado do tipo inteiro.
double altura; // variavel que recebe um dado do tipo double para pontos flutuantes.
double peso;  // variavel que recebe um dado do tipo double para pontos flutuantes.


bool continuar = true; //Variavel booleana iniciada como verdadeira para continuar (loop) do-while para gerar novo relatório.
do // abertura do loop.
{
Console.WriteLine("------[ CALCULADORA DE IMC E IDADE ]-----");//Faz a impressão da string no console: ------[ CALCULADORA DE IMC E IDADE ]-----

// //==================================================
// //            CADASTRANDO DADOS USUARIO
// //==================================================

Console.Write("\nDigite seu nome: ");//Solicita ao usuário a digitar seu nome.
nome = Console.ReadLine();//Faz a leitura da entrada do nome digitado pelo usuario atribuindo a variavel "nome"

Console.Write($"Digite sua idade: ");//Solicita ao usuário a digitar sua idade.
idade = int.Parse(Console.ReadLine());//Faz a leitura da entrada da idade digitada pelo usuario atribuindo a variavel "idade" usando o método "double.Parse para converter em "int".

Console.Write("Digite sua altura: ");//Solicita ao usuário a digitar sua altura.
altura = double.Parse(Console.ReadLine());//Faz a leitura da entrada da altura digitada pelo usuario atribuindo a variavel "altura" usando o método "double.Parse para converter em "double".

Console.Write("Digite seu peso: ");//Solicita ao usuário a digitar seu peso.
peso = double.Parse(Console.ReadLine());//Faz a leitura da entrada do peso digitado pelo usuario atribuindo a variavel "peso" usando o método "double.Parse para converter em "double".


// //====================================================
// //               CALCULANDO IMC
// //====================================================

double imc = peso / (altura*altura); // Variavel "double imc" criada atribuindo a formula de calculo de IMC representado por peso/(altura*altura)
Console.Write($"\nSeu IMC é : ==> {imc}");// Faz a impressão do resultado gerado pela formula de calculo de IMC .


// //====================================================
// //   CATEGORIA DE IMC (usando if , else if , else)
// //====================================================

string categoriaIMC = DeterminarCategoriaIMC(imc); // Função "DeterminarCategoriaIMC" definida para receber variavel do tipo "double imc " que determina a categoriaIMC do usuário retornando em uma string.
string DeterminarCategoriaIMC(double imc)

{ 
    if (imc< 18.5)// Verifica se imc for menor que 18.5. Se for menor, retorna uma string "Abaixo do peso" que armazenará na função "DeterminarCategoriaIMC" impresso no relatório.
        return "Abaixo do peso";
    else if (imc < 25)// Senão se verifica se imc for menor que 25 e maior que 18.5 .Retorna uma string "Normal" que armazenará na função "DeterminarCategoriaIMC" impresso no relatório.
        return "Normal";
    else if (imc < 30)// Senão se verifica se imc for menor que 30 e maior que 25 .Retorna uma string "Sobrepeso" que armazenará na função "DeterminarCategoriaIMC" impresso no relatório.
        return "Sobrepeso";
    else// Se nenhuma das condições acima for verdadeira retorna a string "Obeso" que armazenará na função "DeterminarCategoriaIMC" impresso no relatório.
        return "Obeso";
}

// //====================================================
// //   CATEGORIA DE IDADE (usando if , else if , else)
// //====================================================

string faixaEtaria = DeterminarFaixaEtaria (idade); // Função "DeterminarFaixaEtaria" definida para receber variavel do tipo "int idade " que determina a faixaEtaria do usuário retornando em uma string.
string DeterminarFaixaEtaria(int idade)

{
    if (idade < 12) // Verifica se idade for menor que 12. Se for menor, retorna uma string "Criança" que armazenará na função "DeterminarFaixaEtaria" impresso no relatório.
        return "Criança";
    else if (idade < 18) // Senão se verifica se idade for menor que 18 e maior que 12 .Retorna uma string "Adolescente" que armazenará na função "DeterminarFaixaEtaria" impresso no relatório.
        return "Adolescente";
    else if (idade < 60)// Senão se verifica se idade for menor que 60 e maior que 18 .Retorna uma string "Adulto" que armazenará na função "DeterminarFaixaEtaria" impresso no relatório.
        return "Adulto";
    else// Se nenhuma das condições acima for verdadeira retorna a string "Idoso" que armazenará na função "DeterminarFaixaEtaria" impresso no relatório.
        return "Idoso";
}

// //====================================================
// //                 GERANDO RELATÓRIO
// //====================================================

Console.WriteLine("\n=== Relatório ==="); // Faz impressão no console da string "=== Relatório ==="
Console.WriteLine($"\nNome: {nome}"); // Faz impressão no console da string "Nome" com interpolação da variavel "nome" guardada dentro das chaves que vai ser impressa no console do relatório.
Console.WriteLine($"Idade: {idade} anos");// Faz impressão no console da string "Idade" e "anos" com interpolação da variavel "idade" guardada dentro das chaves que vai ser impressa no console do relatório.
Console.WriteLine($"IMC: " + imc + " (" + categoriaIMC + ")");// Faz impressão no console da string "IMC" com concatenação da variavel "imc" e "categoriaIMC"que vai ser impressa no console do relatório.
Console.WriteLine($"Faixa Etária:" + idade + " (" + faixaEtaria + ")");// Faz impressão no console da string "Faixa Etária" com concatenação da variavel "Idade" e "faixaEtaria"  que vai ser impressa no console do relatório.

Console.Write("\nDeseja gerar um novo relatório para outra pessoa? (s/n): ");//Exibe mensagem ao usuário pergunta se deseja gerar novo relatório.
string resposta = Console.ReadLine();//Guarda a resposta do usuário na variavel "resposta " do tipo string por meio do método Readline aonde se dá a entrada da resposta.

continuar = resposta.ToLower() == "s";//Uso do método ToLower para converte a resposta gerada em letras minusculas atribuindo a letra "s" como verdadeiro na continuidade do loop.

} while(continuar); //fechamento do loop

Console.WriteLine("Programa encerrado.");//Exibe mensagem de "Programa encerrado" caso o usuario digite "n" para não gerar novo relatório.












