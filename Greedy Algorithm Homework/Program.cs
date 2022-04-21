double amount = 0;
double productCost = 0;
double change = 0;
double result = 0;

Console.WriteLine($"Enter an amount of money:");
amount = double.Parse(Console.ReadLine());
Console.WriteLine($"Enter the product cost:");
productCost = double.Parse(Console.ReadLine());
change = amount - productCost;
Console.WriteLine($"Your change is {change}");

double[] coins = {2.00, 1.00, 0.50, 0.10, 0.05, 0.02, 0.01};

for (int i = 0; i < coins.Length; i++)
{
    result = (int)(change / coins[i]);
    change -= result * coins[i];
    Console.WriteLine($"{result} x {coins[i]}");
}
