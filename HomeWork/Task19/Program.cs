/*
Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int revNum = num;
int total = 0;
int digit;

for (num = revNum; num != 0; num = num / 10)
{
    digit = num % 10;
    total = (total * 10) + digit;
}
if (total == revNum)
{
    Console.WriteLine($"Число {revNum} является палиндромом");
}
else
{
    Console.WriteLine($"Число {revNum} не является палиндромом");
}
Console.ReadLine();

