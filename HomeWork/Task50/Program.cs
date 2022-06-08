/*
Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9
*/

int[,] FillArray(int rowNumber, int colNumber, int deviation)
{
    int[,] result = new int[rowNumber, colNumber];

    for (var i = 0; i < rowNumber; i++)
    {
        for (var j = 0; j < colNumber; j++)
        {
            result[i, j] = new Random().Next(-deviation, deviation);
            //result[i, j] = i+j;
        }
    }
    return result;
}
void print2DArray(int[,] arrayToPrint)
{
    Console.Write($"[ ]\t");
    const int startIndex = 0;
    for (var i = startIndex + 0; i < startIndex + arrayToPrint.GetLength(1); i++)
    {
        Console.Write($"[{(i)}]\t");
    }
    Console.WriteLine();
    for (var i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        Console.Write($"[" + i + "]\t");

        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindNumber(int[,] randomArray, int count = 0)
{
    Console.WriteLine("Введите позицию элемента: ");
    int index = Convert.ToInt32(Console.ReadLine());
    if (index > randomArray.Length || index < 0)
    {
        Console.WriteLine($"\n {index}  Такого элемента нет");
    }
    else
    {
        for (var i = 0; i < randomArray.GetLength(0); i++)
        {
            for (var j = 0; j < randomArray.GetLength(1); j++)
            {
                count++;
                if (count == index)
                {
                    System.Console.WriteLine();
                    Console.WriteLine($"на {index} позиции стоит число {randomArray[i, j]}");
                }
            }
        }
    }

}


int[,] randomArray = FillArray(4, 4,10);

print2DArray(randomArray);
Console.WriteLine();
FindNumber(randomArray);
