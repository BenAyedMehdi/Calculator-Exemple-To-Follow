using Prepare_Calculator.Classes;

Console.WriteLine("Enter two numbers:");
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());

Addition add = new Addition();
double sum = add.Perform(num1, num2);
Console.WriteLine("The sum is: " + sum);