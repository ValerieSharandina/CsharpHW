/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

void createArray(int[] userArray )
{
    for (int i = 0; i < userArray.Length; i++)
    {
        Console.Write($"Введи {i+1} число в массив: ");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void printArray (int[] arrayToPrint)
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("---------------------------");
    Console.ForegroundColor=ConsoleColor.White;
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if(i != arrayToPrint.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine("---------------------------");
    Console.WriteLine();
}

void PositiveNumbers(int[] positive)
{
    int count = 0;
    for (var i = 0; i < positive.Length; i++)
    {
        if(positive[i]>0)
        {
            count++;
        }
    }
    Console.ForegroundColor=ConsoleColor.Yellow;
    Console.WriteLine($"Во введенном массиве количество цифр больше 0 равно {count}");
}

Console.Clear();
Console.Write("Введи размер массива: ");
int size = Convert.ToInt32(Console.ReadLine()); 
int[] array = new int[size];

createArray(array);
printArray(array);
PositiveNumbers(array);