/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний 
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

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

void ProductNumbers(int[] randomArray)
{
    int product;

    for (int i = 0; i < randomArray.Length / 2; i++)
    {
        int number1 = randomArray[i];
        int number2 = randomArray[randomArray.Length - i - 1];
        product = number1 * number2;
        Console.WriteLine($"Произведение {i + 1} пары чисел равно {product}. ");
    }
    if (randomArray.Length % 2 == 0)
    {
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"{randomArray[randomArray.Length / 2]} - элемент, расположенный посередине. ");
    }
} 

Console.WriteLine("Введи размер массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] randomArray = getRandomArray(length, 10);
printArray(randomArray);
ProductNumbers(randomArray);

