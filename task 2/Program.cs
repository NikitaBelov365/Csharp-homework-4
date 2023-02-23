// Задача 27: Напишите программу, которая принимает на 
// вход число и выдаёт сумму цифр в числе.

int InputInt(string msg)
{
    System.Console.WriteLine(msg);
    if (int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Only integer pls");
    return 0;
}

int Counter(int num)
{
    int result = 0;
    while (num > 0)
    {
        result += num % 10;
        num /= 10;
    }
    return result;
}

int inputNumber = InputInt("Input number");
System.Console.WriteLine($"Ammount of all digits in {inputNumber} is equal {Counter(inputNumber)}");