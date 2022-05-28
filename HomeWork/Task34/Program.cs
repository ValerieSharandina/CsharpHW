/*
Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/


int[] getRandomArray(int length)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(100, 1000); 
    }

    return result;
}

void printArray(int[] arrayToPrint)
{
    Console.Write("[");
    for (var i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

int FindEvenNumbers(int[] randomArray)
{
    int count = 0;
    int even;

    for (var i = 0; i < randomArray.Length; i++)
    {
       even = randomArray[i] %2;
       if (even == 0)
       {
           count++;
       }
    
    }
    return count;
}

int[] randomArray = getRandomArray(10);
Console.WriteLine("Массив из трехзначных чисел: ");
printArray(randomArray);

int count = FindEvenNumbers(randomArray);
Console.WriteLine($"количество четных чисел в массиве {count}");
