// // Задача 29: Напишите программу, которая задаёт массив 
// // из 8 элементов и выводит их на экран.

int InputArraySize(string msg)
{
    System.Console.WriteLine(msg);
    if(int.TryParse(Console.ReadLine(), out int value))
    {
        return value;
    }
    System.Console.WriteLine("Only integers pls");
    return 0;
}

int[] ArrayCreation(int arraySize)
{
    int[] array = new int[arraySize];
    return array;
}

void ArrayFill(int[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 9);
    }
}

void ArrayPrint(int[] array)
{
    System.Console.Write($"Here is your array: " + array[0]);
    for (int i = 1; i < array.Length; i++)
    {
        System.Console.Write(", " + array[i]);
    }
    System.Console.Write(".");
}

int arraySize = InputArraySize("Input array size:");
int[] array = ArrayCreation(arraySize);
ArrayFill(array);
ArrayPrint(array);