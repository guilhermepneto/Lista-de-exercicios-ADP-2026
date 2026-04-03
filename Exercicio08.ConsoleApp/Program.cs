// 8. Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

Console.Clear();

Console.Write("Informe o número que deseja verificar: ");
string numero = Console.ReadLine();
int num = Convert.ToInt32(numero);

if (num %2 == 0)
{
    Console.WriteLine("O número é par!");
}
else
{
    Console.WriteLine("O número é ímpar");
}

return;

