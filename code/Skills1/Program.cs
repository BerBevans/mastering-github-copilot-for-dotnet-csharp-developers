// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

void CalculateNumbers(int a, int b)
{
    int sum = a + b;
    int difference = a - b;
    int product = a * b;
    double quotient = (double)a / b;

    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Difference: {difference}");
    Console.WriteLine($"Product: {product}");
    Console.WriteLine($"Quotient: {quotient}");
}