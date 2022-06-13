/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int SumBetweenMN(int numberOne, int numberTwo)
{
    if (numberOne < numberTwo)
    {
        return numberOne + SumBetweenMN(numberOne + 1, numberTwo);
    }
    if (numberOne > numberTwo)
    {
        return numberTwo + SumBetweenMN(numberOne, numberTwo + 1);
    }
    return numberOne;
}

int numberM = 1;
int numberN = 15;
int result = SumBetweenMN(numberM, numberN);
Console.WriteLine($"{result}");
