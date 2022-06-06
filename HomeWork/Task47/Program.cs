/*
Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9

*/
double[,] getRandomArray(int rowNumber, int colNumber, int deviation)
{
    double[,] result = new double[rowNumber, colNumber];
    for (int i = 0; i < rowNumber; i++)
    {
        for (int j = 0; j < colNumber; j++)
        {
            result[i,j] = new Random().NextDouble() * (2 * deviation) - deviation;       
        }
        
    }
    return result;
}
void print2DArray(double[,] arrayToPrint)
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
            Console.Write(Math.Round(arrayToPrint[i,j], 2) + "\t");
        }
        Console.WriteLine();
    }
}
double[,] randomArray = getRandomArray(5, 10, 10);
print2DArray(randomArray);
