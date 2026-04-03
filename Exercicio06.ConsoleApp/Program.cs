//6. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C. 


Console.Clear();

Console.Write("Informe o primeiro número: ");
string num1 = Console.ReadLine();
int numero1 = Convert.ToInt32(num1);

Console.Write("Informe o segundo número: ");
string num2 = Console.ReadLine();
int numero2 = Convert.ToInt32(num2);

Console.Write("Informe o terceiro número: ");
string num3 = Console.ReadLine();
int numero3 = Convert.ToInt32(num3);

int resultado = numero1 + numero2;

if (resultado > numero3)
{

    return;
}
else if (resultado == numero3)
{
    return;
}
else if (resultado < numero3)
{
    Console.Write($"A soma dos valores A e B é de: {resultado}! Menor que valor de C");
}

return;