/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
*/
int[,] Array(int[,] array)
{
    for(var i = 0; i < array.GetLongLength(0); i++)
    {
        for (var j = 0; j < array.GetLongLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
    return array;
}
void PrintArray(int[,] printArray)
{
    for (var i = 0; i < printArray.GetLength(0); i++)
    {
        for (var j = 0; j < printArray.GetLength(1); j++)
        {
            Console.Write($" {printArray[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



void SelectionSortMax(int[,] arrayToSort) 
{    
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToSort.GetLength(1) - 1; j++)
        {
            for (int count = j + 1; count < arrayToSort.GetLength(1); count++)
            {
                if (arrayToSort[i, j] < arrayToSort[i, count])
                {
                    int temp = arrayToSort[i, j];
                    arrayToSort[i, j] = arrayToSort[i, count];
                    arrayToSort[i, count] = temp;
                }
            }
        }
    }
}

var array = new int [5,5];
int[,] result=Array(array);
PrintArray(result);

SelectionSortMax(array);
PrintArray(array);
