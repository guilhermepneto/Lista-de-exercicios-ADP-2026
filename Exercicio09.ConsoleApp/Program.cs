/* 9. Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
a. Ex: 5! = 5 X 4 X 3 X 2 X 1 = 120
b. Pesquise sobre “fatorial”*/

//Precisei consultar alguns fóruns para entender como poderia fazer a multiplicação do fatorial, consultei até o chatGPT para dar uma luz mas fez um código muito mais complexo
//e nao foi de grande ajuda

Console.Clear();

Console.Write("Digite o número para aplicar o fatorial: ");
//Decidi tentar usar o int.Parse para a conversão, usar o convert.toint32 demora mais para escrever
int numero = int.Parse(Console.ReadLine());

int fatorial = 1;

for (int num = 1; num <= numero; num++)
{
    fatorial *= num;
    Console.WriteLine(num + "! = " + fatorial);
}

if (numero <= 0)
{
    Console.Write("Número inválido");
    return;
}
Console.ReadLine();

