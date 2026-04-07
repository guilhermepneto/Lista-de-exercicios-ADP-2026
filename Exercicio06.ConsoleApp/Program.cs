//6. Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C. 


Console.Clear();

Console.Write("Informe o primeiro número: ");
int numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o segundo número: ");
int numero2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o terceiro número: ");
int numero3 = Convert.ToInt32(Console.ReadLine());

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
    Console.Write($"A soma dos valores A e B é de: {resultado}. Menor que o valor de C");
}

return;