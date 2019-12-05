using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercício 1
            //string produto1 = "Computador";
            //string produto2 = "Mesa de escritório";

            //byte idade = 30;
            //int codigo = 5290;
            //char genero = 'M';

            //double preco1 = 2100.0;
            //double preco2 = 650.50;
            //double medida = 53.234567;

            //Console.WriteLine("Produtos:");
            //Console.WriteLine($"{produto1}, cujo preço é $: {preco1:F2}");
            //Console.WriteLine($"{produto2}, cujo preço é $: {preco2:F2}");
            //Console.WriteLine();
            //Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            //Console.WriteLine();
            //Console.WriteLine($"Medida com oito casas decimais: {medida:F8}");
            //Console.WriteLine($"Arredondando (três casas decimais): {medida:F3}");
            //Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
            #endregion
            #region Exercício 2
            //Console.WriteLine("Entre com seu nome completo:");
            //string nome = Console.ReadLine();
            //Console.WriteLine("Quantos quartos tem na sua casa?");
            //int quartos = int.Parse(Console.ReadLine());
            //Console.WriteLine("Entre com o preço de um produto:");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            //string[] vet = Console.ReadLine().Split(' ');
            //string ultimoNome = vet[0];
            //int idade = int.Parse(vet[1]);
            //double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Console.WriteLine(nome);
            //Console.WriteLine(quartos);
            //Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            //Console.WriteLine(ultimoNome);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            #endregion

            //Exercícios propostos 1
            #region 1
            //int v1 = int.Parse(Console.ReadLine());
            //int v2 = int.Parse(Console.ReadLine());
            //int soma = v1 + v2;

            //Console.WriteLine($"SOMA = {soma}");
            #endregion

            #region 2
            //double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double area = 3.14159 * Math.Pow(raio, 2);

            //Console.WriteLine($"A={area.ToString("F4", CultureInfo.InvariantCulture)}");
            #endregion

            #region 3
            //int A = int.Parse(Console.ReadLine());
            //int B = int.Parse(Console.ReadLine());
            //int C = int.Parse(Console.ReadLine());
            //int D = int.Parse(Console.ReadLine());

            //int dif = (A * B - C * D);

            //Console.WriteLine($"DIFERENCA = {dif}");
            #endregion

            #region 4
            //int funcNumber = int.Parse(Console.ReadLine());
            //int hrTrab = int.Parse(Console.ReadLine());
            //double vlrHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //double salary = (double)hrTrab * vlrHora;

            //Console.WriteLine($"NUMBER = {funcNumber}");
            //Console.WriteLine($"SALARY = U$ {salary.ToString("F2", CultureInfo.InvariantCulture)}");
            #endregion

            #region 5
            //string[] peca1 = Console.ReadLine().Split(' ');
            //int cod1 = int.Parse(peca1[0]);
            //int qnt1 = int.Parse(peca1[1]);
            //double vlr1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            //double vlrTotal1 = (double) qnt1 * vlr1;

            //string[] peca2 = Console.ReadLine().Split(' ');
            //int cod2 = int.Parse(peca2[0]);
            //int qnt2 = int.Parse(peca2[1]);
            //double vlr2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            //double vlrTotal2 = (double)qnt2 * vlr2;

            //double vlrTotalGeral = vlrTotal1 + vlrTotal2;

            //Console.WriteLine($"VALOR A PAGAR: R$ {vlrTotalGeral.ToString("F2", CultureInfo.InvariantCulture)}");
            #endregion

            #region 6
            //string[] vet = Console.ReadLine().Split(' ');

            //double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            //double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //double triangulo = (A * C) / 2;
            //double circulo = 3.14159 * Math.Pow(C, 2);
            //double trapezio = (A + B) * C / 2;
            //double quadrado = Math.Pow(B, 2);
            //double retangulo = A * B;

            //Console.WriteLine($"TRIANGULO: {triangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"CIRCULO: {circulo.ToString("F3", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"TRAPEZIO: {trapezio.ToString("F3", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"QUADRADO: {quadrado.ToString("F3", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"RETANGULO: {retangulo.ToString("F3", CultureInfo.InvariantCulture)}");
            #endregion

            //Exercícios propostos 2
            #region 1
            //int number = int.Parse(Console.ReadLine());

            //if (number < 0)
            //    Console.WriteLine("NEGATIVO");
            //else
            //    Console.WriteLine("NAO NEGATIVO");
            #endregion

            #region 2
            //int number = int.Parse(Console.ReadLine());

            //if ((number % 2) == 0)
            //    Console.WriteLine("PAR");
            //else
            //    Console.WriteLine("IMPAR");
            #endregion

            #region 3
            //string[] vet = Console.ReadLine().Split(' ');
            //int A = int.Parse(vet[0]);
            //int B = int.Parse(vet[1]);

            //static string VerificaMultiplos(int A, int B)
            //{
            //    if (A % B == 0)
            //        return "Sao Multiplos";
            //    else
            //        return "Nao sao multiplos";
            //}

            //if (A > B)
            //    Console.WriteLine(VerificaMultiplos(A, B));
            //else
            //    Console.WriteLine(VerificaMultiplos(B, A));
            #endregion

            #region 4
            //string[] vet = Console.ReadLine().Split(' ');
            //int horaInicial = int.Parse(vet[0]);
            //int horaFinal = int.Parse(vet[1]);

            //if (horaFinal <= horaInicial)
            //{
            //    int duracao = 24 - horaInicial + horaFinal;
            //    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            //}
            //else
            //{
            //    int duracao = horaFinal - horaInicial;
            //    Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            //}
            #endregion

            #region 5
            //string[] vet = Console.ReadLine().Split(' ');
            //int cod = int.Parse(vet[0]);
            //int qnt = int.Parse(vet[1]);
            //double total = 0;

            //if (cod == 1)
            //    total += qnt * 4.0;
            //else if (cod == 2)
            //    total += qnt * 4.5;
            //else if (cod == 3)
            //    total += qnt * 5.0;
            //else if (cod == 4)
            //    total += qnt * 2.0;
            //else if (cod == 5)
            //    total += qnt * 1.5;

            //Console.WriteLine($"Total: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
            #endregion

            #region 6
            //double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (valor > 0 && valor <= 25)
            //{
            //    Console.WriteLine("Intervalo [0,25]");
            //}
            //else if (valor > 25 && valor <= 50)
            //{
            //    Console.WriteLine("Intervalo [25,50]");
            //}
            //else if (valor > 50 && valor <= 75)
            //{
            //    Console.WriteLine("Intervalo [50,75]");
            //}
            //else if (valor > 75 && valor <= 100)
            //{
            //    Console.WriteLine("Intervalo [75,100]");
            //}
            //else
            //{
            //    Console.WriteLine("Fora de intervalo");
            //}
            #endregion

            #region 7
            //string[] vet = Console.ReadLine().Split(' ');
            //double x = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //double y = double.Parse(vet[1], CultureInfo.InvariantCulture);

            //if (x == 0 && y == 0)
            //    Console.WriteLine("Origem");
            //else if (x == 0 && y > 0)
            //    Console.WriteLine("Eixo X");
            //else if (x > 0 && y == 0)
            //    Console.WriteLine("Eixo Y");
            //else if (x > 0 && y < 0)
            //    Console.WriteLine("Q4");
            //else if (x > 0 && y > 0)
            //    Console.WriteLine("Q1");
            //else if (x < 0 && y < 0)
            //    Console.WriteLine("Q3");
            //else if (x < 0 && y > 0)
            //    Console.WriteLine("Q2");
            #endregion

            #region 8
            //double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //if (valor >= 0.00 && valor <= 2000.00)
            //{
            //    Console.WriteLine("Isento");
            //}
            //else if  (valor > 2000.00 && valor <= 3000.00)
            //{
            //    double ir = (valor - 2000.00) * 0.08;
            //    Console.WriteLine($"R$ {ir.ToString("F2", CultureInfo.InvariantCulture)}");
            //}
            //else if (valor > 3000.00 && valor <= 4500.00)
            //{
            //    double ir = ((valor - 3000.00) * 0.18) + 80.00;
            //    Console.WriteLine($"R$ {ir.ToString("F2", CultureInfo.InvariantCulture)}");
            //}
            //else
            //{
            //    double ir = ((valor - 4500.00) * 0.28) + 350.00;
            //    Console.WriteLine($"R$ {ir.ToString("F2", CultureInfo.InvariantCulture)}");
            //}
            #endregion

            //Exercícios propostos 3

            #region 1
            //int senha = int.Parse(Console.ReadLine());

            //while (senha != 2002)
            //{
            //    Console.WriteLine("Senha inválida");
            //    senha = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Acesso Permitido");
            #endregion

            #region 2
            //string[] vet = Console.ReadLine().Split(' ');
            //int x = int.Parse(vet[0]);
            //int y = int.Parse(vet[1]);

            //while (x != 0 && y != 0)
            //{
            //    if (x > 0 && y > 0)
            //        Console.WriteLine("primeiro");
            //    else if (x > 0 && y < 0)
            //        Console.WriteLine("quarto");
            //    else if (x < 0 && y < 0)
            //        Console.WriteLine("terceiro");
            //    else
            //        Console.WriteLine("segundo");

            //    vet = Console.ReadLine().Split(' ');
            //    x = int.Parse(vet[0]);
            //    y = int.Parse(vet[1]);
            //}
            #endregion

            #region 3
            //int valor = int.Parse(Console.ReadLine());
            //int alcool = 0, gasolina = 0, diesel = 0;

            //while (valor != 4)
            //{
            //    if (valor == 1)
            //        alcool++;
            //    else if (valor == 2)
            //        gasolina++;
            //    else if (valor == 3)
            //        diesel++;

            //    valor = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("MUITO OBRIGADO");
            //Console.WriteLine($"Alcool: {alcool}");
            //Console.WriteLine($"Gasolina: {gasolina}");
            //Console.WriteLine($"Diesel: {diesel}");
            #endregion

            //Exercícios propostos 4

            #region 1
            //int X = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= X; i++)
            //{
            //    if (i % 2 != 0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 2
            //int N = int.Parse(Console.ReadLine());
            //int dentro = 0, fora = 0;

            //for (int i = 0; i < N; i++)
            //{
            //    int valor = int.Parse(Console.ReadLine());

            //    if (valor >= 10 && valor <= 20)
            //        dentro++;
            //    else
            //        fora++;
            //}

            //Console.WriteLine($"{dentro} in");
            //Console.WriteLine($"{fora} out");
            #endregion

            #region 3
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{
            //    string[] vet = Console.ReadLine().Split(' ');
            //    double v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //    double v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            //    double v3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            //    v1 *= 0.2;
            //    v2 *= 0.3;
            //    v3 *= 0.5;

            //    double media = v1 + v2 + v3;

            //    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            //}
            #endregion

            #region 4
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 0; i < N; i++)
            //{
            //    string[] vet = Console.ReadLine().Split(' ');
            //    double v1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            //    double v2 = double.Parse(vet[1], CultureInfo.InvariantCulture);

            //    if (v2 == 0)
            //        Console.WriteLine("Divisão impossível");
            //    else
            //    {
            //        double divisao = v1 / v2;
            //        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //}
            #endregion

            #region 5
            //int N = int.Parse(Console.ReadLine());

            //if (N == 0)
            //    Console.WriteLine(1);
            //else
            //{
            //    for (int i = N - 1; i != 0; i--)
            //    {
            //        N = N * (i);
            //    }

            //    Console.WriteLine(N);
            //}
            #endregion

            #region 6
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    if (N % i == 0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region 7
            //int N = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= N; i++)
            //{
            //    double quadrado = Math.Pow(i, 2);
            //    double cubo = Math.Pow(i, 3);

            //    Console.WriteLine($"{i} {quadrado} {cubo}");
            //}
            #endregion

            //Exercícios POO

            #region 1
            //Pessoa p1, p2;
            //p1 = new Pessoa();
            //p2 = new Pessoa();

            //Console.WriteLine("Dados da primeira pessoa:");
            //Console.Write("Nome: ");
            //p1.Nome = Console.ReadLine();

            //Console.Write("Idade: ");
            //p1.Idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados da segunda pessoa:");
            //Console.Write("Nome: ");
            //p2.Nome = Console.ReadLine();

            //Console.Write("Idade: ");
            //p2.Idade = int.Parse(Console.ReadLine());

            ////string maisVelha = p1.Idade > p2.Idade ? p1.Nome : p2.Nome;

            //if (p1.Idade > p2.Idade)
            //    Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            //else
            //    Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            #endregion

            #region 2
            //Funcionario f1, f2;
            //f1 = new Funcionario();
            //f2 = new Funcionario();

            //Console.WriteLine("Dados do primeiro funcionário:");
            //Console.Write("Nome: ");
            //f1.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //f1.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine("Dados do segundo funcionário:");
            //Console.Write("Nome: ");
            //f2.Nome = Console.ReadLine();
            //Console.Write("Salário: ");
            //f2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //double salarioMedio = (f1.Salario + f2.Salario) / 2;

            //Console.WriteLine($"Salário médio = {salarioMedio.ToString("F2", CultureInfo.InvariantCulture)}");
            #endregion

            //Exercícios POO 2
            #region 1
            //Retangulo r = new Retangulo();
            //Console.WriteLine("Entre a largura e altura do retângulo:");
            //r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"AREA = {r.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"PERÍMETRO = {r.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            //Console.WriteLine($"DIAGONAL = {r.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");
            #endregion

            #region 2
            //Funcionario2 f = new Funcionario2();
            //Console.Write("Nome: ");
            //f.Nome = Console.ReadLine();
            //Console.Write("Salário bruto: ");
            //f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Console.Write("Imposto: ");
            //f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine();
            //Console.WriteLine($"Funcionário: {f}");
            //Console.WriteLine();
            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //f.AumentarSalario(porcentagem);
            //Console.WriteLine();
            //Console.WriteLine($"Dados atualizados: {f}");
            #endregion

            #region 3
            //Aluno a = new Aluno();
            //Console.Write("Nome do aluno: ");
            //a.Nome = Console.ReadLine();
            //Console.WriteLine("Digite as três notas do aluno:");
            //a.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //a.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //a.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"NOTA FINAL = {a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture)}");
            //if (a.Aprovado())
            //{
            //    Console.WriteLine("APROVADO");
            //}
            //else
            //{
            //    Console.WriteLine("REPROVADO");
            //    Console.WriteLine($"FALTARAM {a.FaltaPontos().ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            //}
            #endregion

            #region 4
            Console.Write("Qual é a cotação do dólar: ");
            double cotDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar: ");
            double qntDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais: " +
                $"{ConversorDeMoeda.ValorPagar(cotDolar, qntDolar).ToString("F2", CultureInfo.InvariantCulture)}");
            #endregion
        }
    }
}

