// See https://aka.ms/new-console-template for more information
using System.Xml.Serialization;

calculatorApp();

void calculatorApp() {

    int firstNumber = 0;
    int secondNumber = 0;
    int result = 0;
    int choice = 0;

    Console.WriteLine("Enter your first number");
    firstNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter your second number");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("1 - Add");
    Console.WriteLine("2 - Subtract");
    Console.WriteLine("3 - Multiply");
    Console.WriteLine("4 - Divide");

    choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1)
    {
        result = firstNumber + secondNumber;
        Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 2)
    {
        result = firstNumber - secondNumber;
        Console.WriteLine("Subtracting {0} and {1} give the answer {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 3)
    {
        result = firstNumber * secondNumber;
        Console.WriteLine("Multiplying {0} and {1} give the answer {2}", firstNumber, secondNumber, result);
    }
    else if (choice == 4)
    {
        result = firstNumber / secondNumber;
        Console.WriteLine("Dividing {0} and {1} give the answer {2}", firstNumber, secondNumber, result);
    }
    else
    {
        Console.WriteLine("Invalid choice");
    }
    {
        
    }

    result = firstNumber + secondNumber;

    Console.WriteLine("Adding {0} and {1} give the answer {2}", firstNumber, secondNumber, result);
    }
