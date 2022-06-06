/*
Задача 44: Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

void createArray(int[] arrayFibonacci)
{
    for (int i = 0; i < 2; i++)
        {
            arrayFibonacci[i] = i;
            Console.Write(arrayFibonacci[i]);
            if (i != 1)
            {
                Console.Write(", ");
            }
        }
        if (arrayFibonacci.Length > 2)
        {
            Console.Write(", ");
        }
        for (int i = 2; i < arrayFibonacci.Length; i++)
        {
            arrayFibonacci[i] = arrayFibonacci[i - 2] + arrayFibonacci[i - 1];
            Console.Write(arrayFibonacci[i]);
            if (i != arrayFibonacci.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.Write(".");
    }    

Console.WriteLine("Сколько чисел Фибоначчи надо?");
int n = Convert.ToInt32(Console.ReadLine());
int[] fibonacci = new int[n];
createArray(fibonacci);
