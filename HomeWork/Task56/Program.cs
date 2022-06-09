/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
*/

int[,] RandomArray(int rowNumber, int colNumber)
{
    int[,] result = new int[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(1, 3);
        }
    }
    return result;
}


void PrintArray(int[,] arrayToPrint)
{
    Console.WriteLine();
    Console.Write("[ ]\t");
    const int startIndex = 65;
    for (int columnName = startIndex + 0; columnName < startIndex + arrayToPrint.GetLength(1); columnName++)
    {
        Console.Write($"[{((char)columnName)}]\t");
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
Console.Write("Введи количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

void MinSumRow(int[,] findSum)
{
    
    int minSum = 0;
    int tempSum1 = 0;
    int tempSum2 = 0;
    int rowNum = 0;
    for (int i = 0; i < rows; i++)
    {
        tempSum2 = 0;
        for (int j = 0; j < columns; j++)
        {
            tempSum2 += findSum[i, j];
        }
        if (tempSum2 < tempSum1)
        {
            minSum = tempSum2;
            rowNum = i;
        }
        tempSum1 = tempSum2;
    }
    Console.WriteLine($"Минимальная сумма элементов в строке [{rowNum}].");
}



int[,] randomArray = RandomArray(rows, columns);
PrintArray(randomArray);

MinSumRow(randomArray);
