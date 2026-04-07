//5. Crie um programa para calcular a média ponderada de duas provas realizadas por um aluno

Console.Clear();

Console.Write("Informe a primeira nota: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o peso da primeira prova: ");
double peso1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a primeira nota: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o peso da segunda prova: ");
double peso2 = Convert.ToDouble(Console.ReadLine());

double media_final = ((nota1 * peso1) + (nota2 * peso2)) / (peso1 + peso2);

Console.WriteLine($"A média final do aluno foi de: {media_final:F2}");

if (media_final >= 7)
    Console.Write("O aluno está aprovado!");
else
    Console.Write("O aluno está reprovado!");

return;