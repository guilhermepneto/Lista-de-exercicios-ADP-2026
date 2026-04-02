//1. Crie um programa para calcular o volume de uma caixa retangular

Console.Clear();

Console.Write("Digite o valor do comprimento: ");
double comprimento = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor da largura: ");
double largura = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor da altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double resultado = comprimento * altura * largura;

Console.WriteLine($"O volume da caixa é: {resultado:F2} cm³");

return;
