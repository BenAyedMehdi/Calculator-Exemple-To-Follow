using Prepare_Calculator.Classes;

Console.WriteLine("Enter two numbers:");
double num1 = double.Parse(Console.ReadLine());
double num2 = double.Parse(Console.ReadLine());

Addition add = new Addition();
double sum = add.Perform(num1, num2);
Console.WriteLine("The sum is: " + sum);

Subtraction sub = new Subtraction();
double difference = sub.Perform(num1, num2);
Console.WriteLine("The difference is: " + difference);

Multiplication mult = new Multiplication();
double product = mult.Perform(num1, num2);
Console.WriteLine("The product is: " + product);

Division div = new Division();
double quotient = div.Perform(num1, num2);
Console.WriteLine("The quotient is: " + quotient);

Console.ReadLine();