/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76


*/

double[] getRandomArray(int length)
{
    double[] result = new double[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().NextDouble() * 100; 
    }

    return result;
}

void printArray(double[] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(Math.Round(arrayToPrint[i], 1));
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

void MaxMinrandomArraysArray(double[] randomArray)
{
    double max = randomArray[0];
    double min = randomArray[0];
    for (var i = 0; i < randomArray.Length; i++)
    {
        if(randomArray[i] > max)
        {
            max = randomArray[i];
        }
    }
    Console.WriteLine($"Максимальный элемент массива {Math.Round(max, 1)}");

    for (var i = 0; i < randomArray.Length; i++)
    {
        if(randomArray[i] < min)
        {
            min = randomArray[i];
        }
    }
    Console.WriteLine($"Минимальный элемент массива {Math.Round(min, 1)}");

    double diff = max - min;
    Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Math.Round(diff, 1)}");
}

Console.Write("Введи размер массива ");
int length = Convert.ToInt32(Console.ReadLine());

double[] randomArray = getRandomArray(length);
printArray(randomArray);
MaxMinrandomArraysArray(randomArray);
