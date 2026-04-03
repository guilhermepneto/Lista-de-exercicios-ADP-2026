/* 7. O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta. 
A fórmula é IMC = peso / (altura)².
Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
a. IMC em adultos Condição
b. Abaixo de 18,5
c. Abaixo do peso
d. Entre 18,5 e 25 Peso normal
e. Entre 25 e 30
f. Acima do peso
g. Acima de 30 obeso*/

Console.Clear();

Console.Write("Informe o peso: ");
double peso = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a altura: ");
double altura = Convert.ToDouble(Console.ReadLine());

double imc = peso / (altura * altura);

if (imc < 18.5)
{
    Console.WriteLine($"O valor de IMC é de: {imc:F2}. Essa pessoa está abaixo do peso ideal");
}
else if (imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine($"O valor de IMC é de: {imc:F2}. Essa pessoa está no peso ideal");
}
else if (imc > 25 && imc <= 30)
{
    Console.WriteLine($"O valor de IMC é de: {imc:F2}. Essa pessoa está acima do peso ideal");
}
else if (imc > 30)
{
    Console.WriteLine($"O valor de IMC é de: {imc:F2}. Essa pessoa está obesa");
}

return;