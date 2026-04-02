//3. Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

//(x °C × 9/5) + 32 = ºFahrenheit

Console.Clear();

Console.Write("Digite o valor da temperatura em graus Celsius: ");
double celsius = Convert.ToDouble(Console.ReadLine());

//Poderia usar o valor já resolvido da fração que é 1,8, para melhor visualização, mas matematicamente é a mesma coisa.
double resposta = (celsius * 9 / 5) + 32;

Console.Write($"A temperatura convertida de Celsius para Fahrenheit é de: {resposta:F1}");

return;