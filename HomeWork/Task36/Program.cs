/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Введи размер массива");
int length = Convert.ToInt32(Console.ReadLine());


int[] getRandomArray(int length, int deviation)
{
    int[] result = new int[length];
    for (var i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation + 1);
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

int SumEvenIndexNumers(int[] randomArray)
{
    int evenIndex;
    int sum = 0;
 for (var i = 0; i < randomArray.Length; i++)
 {
     evenIndex = i % 2;
     if (evenIndex == 1)
     {
         sum = sum + randomArray[i];
     }
 }
 return sum;
}

int[] randomArray = getRandomArray(length, 1000);
printArray(randomArray);

int sum = SumEvenIndexNumers(randomArray);
Console.WriteLine($"сумма элементов стоящих на нечетных позициях равна {sum}");