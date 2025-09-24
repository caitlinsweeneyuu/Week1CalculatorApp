// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter your first number");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your second number");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);