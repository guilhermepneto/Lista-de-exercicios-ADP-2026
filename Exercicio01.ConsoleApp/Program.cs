//1. Crie um programa para calcular o volume de uma caixa retangular

Console.Clear();

Console.Write("Digite o valor do comprimento: ");
string comprimento = Console.ReadLine();
int c = Convert.ToInt32(comprimento);

Console.Write("Digite o valor da largura: ");
string largura = Console.ReadLine();
int l = Convert.ToInt32(largura);

Console.Write("Digite o valor da altura: ");
string altura = Console.ReadLine();
int a = Convert.ToInt32(altura);

int resultado = c * a * l;

Console.WriteLine($"O volume da caixa é: {resultado:F2} cm³");

return;
