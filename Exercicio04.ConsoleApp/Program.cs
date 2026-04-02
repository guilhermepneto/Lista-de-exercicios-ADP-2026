/*4. Crie um programa para calcular o salário total de um vendedor. 
Deverá ser informado o salário base e o total de vendas. 
A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.*/

Console.Clear();

Console.Write("Informe o salário base do vendedor: ");
double salario = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor total das vendas: ");
double vendas = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe, em porcentagem, o valor da comissão do vendedor. (Não precisa usar o %) ");
double comissao = Convert.ToDouble(Console.ReadLine());

double comissao_total = vendas * (comissao / 100);
double salario_total = salario + comissao_total;

Console.WriteLine($"A comissão do mês é de: {comissao_total:F2}");
Console.Write($"O salário total do vendedor com comissão, será de: {salario_total:F2}");

return;