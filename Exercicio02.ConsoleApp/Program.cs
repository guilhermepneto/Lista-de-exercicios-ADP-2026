/*2. Crie um programa que calcule o consumo de combustível por quilômetro percorrido em uma viagem.
O programa deve solicitar ao usuário:
    a. A quilometragem inicial do veículo no início da viagem.
    b. A quilometragem final ao término da viagem.
    c. A quantidade de combustível consumida durante a viagem (em litros).*/

Console.Clear();

Console.Write("Informe a quantidade de KM percorrida: ");
double km = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe a quantidade de litros de combustível abastecidos: ");
double combustivel = Convert.ToDouble(Console.ReadLine());

double media = km / combustivel;

Console.WriteLine($"A média realizada pelo carro foi de: {media:F1} km/l");

return;