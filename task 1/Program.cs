// Задача 25: Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    if(int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Only integer pls");
    return 0;
}

int Exponentiation(int num, int num1)
{
    int exponent = 1;
    for (int i = 1; i <= num1; i++)
    {
        exponent *= num;
    }
    return exponent;
}

int firstNumber = InputInt("Enter first number:");
int secondNumber = InputInt("Enter second number:");
System.Console.WriteLine(Exponentiation(firstNumber, secondNumber));