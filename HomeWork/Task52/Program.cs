/*
Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

int[,] getRandomArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation);
        }
    }
    return result;
}

void PrintArray(int[,] arrayToPrint)
{
    Console.Write("[ ]\t");
    const int startIndex = 65;
    for (int i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{((char)i)}]\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[{i}]\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void Average(int[,] averageСolumn)
{

    Console.WriteLine();
    double sum = 0;
    const int startIndex = 65;
    for (int j = 0; j < averageСolumn.GetLength(1); j++)
    {
        int columnName = j + startIndex;
        for (int i = 0; i < averageСolumn.GetLength(0); i++)
        {
            sum += averageСolumn[i, j];
        }
        Console.Write($"Среднее арифметическое столбца [{((char)columnName)}]: ");
        Console.WriteLine(Math.Round(sum / (averageСolumn.GetLength(0)), 2));
    }
}



int[,] randomArray = getRandomArray(4,4,10);
PrintArray(randomArray);
Average(randomArray);
Console.ReadLine();

