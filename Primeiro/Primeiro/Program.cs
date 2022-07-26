using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Entrada de Dados Parte 1
            //string cores = Console.ReadLine();

            //string[] vet = Console.ReadLine().Split(' ');

            //string corAmarelo = vet[0];
            //string corLaranja = vet[1];
            //string corCinza = vet[2];

            //Console.WriteLine(corAmarelo);
            //Console.WriteLine(corLaranja);
            //Console.WriteLine(corCinza);



            //Console.ReadLine();
            #endregion

            #region Entrada de Dados Parte 2 

            ////usar o Parse para converter uma string em um tipo no qual se informe a frente: Ex: int.Parse, char.Parse, double.Parse
            //int num = int.Parse(Console.ReadLine());
            //char f = char.Parse(Console.ReadLine());
            //double num2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Você digitou: ");
            //Console.WriteLine(num);
            //Console.WriteLine(f);
            //Console.WriteLine(num2);

            //string[] info = Console.ReadLine().Split(' ');
            //string nome = info[0];
            //char sexo = char.Parse(info[1]);
            //int idade = int.Parse(info[2]);
            //double altura = double.Parse(info[3], CultureInfo.InvariantCulture);

            //Console.WriteLine(nome);
            //Console.WriteLine(sexo);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2" , CultureInfo.InvariantCulture));
            //Console.ReadLine();


            #endregion

            #region Exercício de Fixação 
            /*Fazer um programa para executar a seguinte interação com o usuário,
            lendo os valores destacados, e depois mostrar os dados na tela:
             Entre com seu Nome Completo:
             Mariana de Oliveira Léo
             Quantos quartos tem na sua casa?
             2
             Entre com o preço de um produto:
             500.50
            Entre com seu último nome, idade e altura (mesma linha):
            Léo, 24, 1.65*/


            //Console.WriteLine("Entre com seu nome completo: ");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Quantos quartos tem na sua casa? ");
            //int quartos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o preço de um produto: ");
            //double produto = double.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
            //string[] info = Console.ReadLine().Split(' ');
            //string ultimoNome = info[0];
            //int idade = int.Parse(info[1]);
            //double altura = double.Parse(info[2], CultureInfo.InvariantCulture);

            //Console.WriteLine(nome);
            //Console.WriteLine(quartos);
            //Console.WriteLine(produto);
            //Console.WriteLine(ultimoNome);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            //Console.ReadLine();
            #endregion

            #region Exercício Resolvido
            /* Fazer um programa para ler as medidas da largura e comprimento
             de  um terreno retangular com uma casa decimal, bem como o valor do metro quadrado 
            do terreno com duas casas decimais. Em seguida, o programa deve mostrar o valor
            da área do terreno, bem como o valor do preço do terreno, ambos com duas casas decimais, 
            conforme exemplo :
            Entrada:                  Saída
            10.0                      AREA= 300,00
            30.0                      PRECO = 60000,00
            200.00*/

            //double largura, comprimento, metroQuadrado, area, preco;

            //Console.WriteLine("Largura: ");
            //largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Altura: ");
            //comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Preço do metro quadrado: ");
            //metroQuadrado = double.Parse(Console.ReadLine());

            //area = largura * comprimento;
            //preco = area * metroQuadrado;

            //Console.WriteLine("AREA: " + area.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine("PREÇO: " + preco.ToString("F2"));
            //Console.ReadLine();
            #endregion

            #region Primeiro Exercício URI Online Judge
            //int A, B, X;

            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());


            //X = A + B;

            //Console.WriteLine("X = " + X);
            //Console.ReadLine();
            #endregion

            #region Exercícios Propostos Parte 1 - 1002
            //A fórmula para calcular a área de uma circunferência é: area = π.raio2.Considerando para este problema que π = 3.14159:
            //-Efetue o cálculo da área, elevando o valor de raio ao quadrado e multiplicando por π.

            //Entrada
            //A entrada contém um valor de ponto flutuante(dupla precisão), no caso, a variável raio.

            //Saída
            //Apresentar a mensagem "A=" seguido pelo valor da variável area,
            //conforme exemplo abaixo, com 4 casas após o ponto decimal.Utilize variáveis de dupla precisão(double).
            //Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado,
            //caso contrário, você receberá "Presentation Error".

            //double area, raio, pi= 3.14159;

            //raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //area = pi * Math.Pow(raio, 2);

            //Console.WriteLine("A= " + area.ToString("F4",CultureInfo.InvariantCulture));
            //Console.ReadLine();

            #endregion

            #region Exercícios Propostos Parte 1 - 1003
            //Leia dois valores inteiros, no caso para variáveis A e B. A seguir, calcule a soma entre elas e atribua à variável SOMA.
            //A seguir escrever o valor desta variável.

            //Entrada
            //O arquivo de entrada contém 2 valores inteiros.

            //Saída
            //Imprima a mensagem "SOMA" com todas as letras maiúsculas, com um espaço em branco antes e depois da igualdade seguido
            //pelo valor correspondente à soma de A e B. 
            //Como todos os problemas, não esqueça de imprimir o fim de linha após o resultado,
            //caso contrário, você receberá "Presentation Error".

            //int A, B, SOMA;

            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());

            //SOMA = A + B;

            //Console.WriteLine("SOMA = " + SOMA);
            //Console.ReadLine();
            #endregion

            #region Exercícios Propostos Parte 1 - 1004
            //Leia dois valores inteiros. A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD.
            //A seguir mostre a variável PROD com mensagem correspondente.

            //Entrada
            //O arquivo de entrada contém 2 valores inteiros.

            //Saída
            //Imprima a mensagem "PROD" e a variável PROD conforme exemplo abaixo, com um espaço em branco antes e depois 
            //da igualdade. Não esqueça de imprimir o fim de linha após o produto, caso contrário seu 
            //programa apresentará a mensagem: “Presentation Error”.

            //int val1, val2, PROD;

            //val1 = int.Parse(Console.ReadLine());
            //val2 = int.Parse(Console.ReadLine());

            //PROD = val1 * val2;

            //Console.WriteLine("PROD = " + PROD);
            //Console.ReadLine();
            #endregion

            #region Exercícios Propostos Parte 1 - 1007
            //Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D 
            //segundo a fórmula: DIFERENCA = (A * B - C * D).

            //Entrada
            //O arquivo de entrada contém 4 valores inteiros.

            //Saída
            //Imprima a mensagem DIFERENCA com todas as letras maiúsculas, conforme exemplo abaixo, 
            //com um espaço em branco antes e depois da igualdade.

            //int A, B, C, D, DIFERENCA;

            //A = int.Parse(Console.ReadLine());
            //B = int.Parse(Console.ReadLine());
            //C = int.Parse(Console.ReadLine());
            //D = int.Parse(Console.ReadLine());

            //DIFERENCA = (A * B - C * D);

            //Console.WriteLine("DIFERENCA = " + DIFERENCA);
            //Console.ReadLine();
            #endregion

            #region Exercícios Propostos Parte 1 - 1008
            //Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, 
            //o valor que recebe por hora e calcula o salário desse funcionário.
            //A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

            //Entrada
            //O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, 
            //representando o número, quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

            //Saída
            //Imprima o número e o salário do funcionário, conforme exemplo fornecido, 
            //com um espaço em branco antes e depois da igualdade. No caso do salário, também deve haver um espaço em branco após o $.

            //int numeroFuncionario, horasTrabalhadas;
            //double valorPorHora, salario;

            //numeroFuncionario = int.Parse(Console.ReadLine());
            //horasTrabalhadas = int.Parse(Console.ReadLine());
            //valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //salario = horasTrabalhadas * valorPorHora;

            //Console.WriteLine("NUMBER = " + numeroFuncionario);
            //Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
            //Console.ReadLine();

            #endregion

            #region Exercícios Propostos Parte 1 - 1010
            // Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
            //o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.Após, calcule e mostre o valor a ser pago.

            //Entrada
            //O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, 
            //respectivamente dois inteiros e um valor com 2 casas decimais.

            //Saída
            //A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, 
            //lembrando de deixar um espaço após os dois pontos e um espaço após o "R$".
            // O valor deverá ser apresentado com 2 casas após o ponto.

            int codPeca1, codPeca2, numPeca1, numPeca2;

            double valPeca1, valPeca2, valTotal;

            string[] dadosPeca1 = Console.ReadLine().Split(' ');
            string[] dadosPeca2 = Console.ReadLine().Split(' ');
            codPeca1 = int.Parse(dadosPeca1[0]);
            numPeca1 = int.Parse(dadosPeca1[1]);
            valPeca1 = double.Parse(dadosPeca1[2], CultureInfo.InvariantCulture);
            codPeca2 = int.Parse(dadosPeca2[0]);
            numPeca2 = int.Parse(dadosPeca2[1]);
            valPeca2 = double.Parse(dadosPeca2[2], CultureInfo.InvariantCulture);

            valTotal = (numPeca1 * valPeca1) + (numPeca2 * valPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + valTotal.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();      

            #endregion

        }
    }
}
