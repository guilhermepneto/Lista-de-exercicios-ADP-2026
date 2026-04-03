/* 10. Escreva um programa que imprima os números de 1 a 100 em ordem crescente, substituindo os números múltiplos de 3 pela palavra "Fizz" 
e os múltiplos de 5 pela palavra "Buzz". Para números que são múltiplos de ambos, use "FizzBuzz".*/

//Esse exercicio eu achei que seria mais complicado, precisei apenas validar se era possível fazer uma comparação dentro do if de dois restos para saber se eram 
//multiplos de 3 e de 5, o que me bateu mais a cabeça foi que essa comparação deve vir primeiro senão o 3 ou 5 invalidam ela pois já estão sendo usadas.
//O exercicio de fatoração me gastou mais o cérebro.

//8 de 10 exercicios consegui fazer só com o que adquiri no curso sem maiores dificuldades. Apenas os 2 ultimos tive mais dificuldades, finalizando às 02:20 do dia 03/04/26

Console.Clear();

int num = 1;

while (num <= 100)
{

    if (num % 3 == 0 && num % 5 == 0)
    {
        Console.WriteLine("FizzBuzz");
    }
    else if (num % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else if (num % 3 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(num);
    }
    num++;
}
return;

