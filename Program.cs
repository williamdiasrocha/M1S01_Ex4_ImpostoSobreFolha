// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
double salario;
double desconto5 = 0.05;
double desconto10 = 0.1;
double desconto20 = 0.2;
double resultado;

Console.WriteLine("Cálculo de Imposto sobre a Folha de Pagamento");
Console.WriteLine("Insira o valor do salário bruto:");
salario = double.Parse(Console.ReadLine());

if (salario <= 900){
    Console.WriteLine("Isento de Arrecadação");
}
else if (salario <=1500){
    Console.WriteLine("Desconto de 5% " + "R$ " + (resultado = salario*desconto5));
}
else if (salario <=2500){
    Console.WriteLine("Desconto de 10% "+ "R$ " + (resultado = salario*desconto10));
}
else if (salario >2500){
    Console.WriteLine("Desconto de 20% " + "R$ " +(resultado = salario*desconto20));
}