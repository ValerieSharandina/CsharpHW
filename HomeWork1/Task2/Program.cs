/*
Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
*/
int[] array = new int [3];
array[0] = 5;
array[1]= 6;
array[2] = 8;

int max = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
  
Console.WriteLine(max);
}

