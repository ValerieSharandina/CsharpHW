/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.Write ("Введите число:  ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number < 100)
{
    Console.WriteLine ($"число {Number} двузначное, третьей цифры нет");
}
else if (Number > 99 && Number < 1000)
{
  int NumberThree = Number % 10 ; 
  int Result = NumberThree;
  Console.WriteLine ($"число {Number} трехзначное, третья цифра  {Result}");
}
else if (Number > 999 && Number < 10000)
{
   int NumberFour = (Number % 100) / 10; 
  int Result = NumberFour;
  Console.WriteLine ($"число {Number} четырехзначное, третья цифра  {Result}");
}
else if (Number > 9999 && Number < 100000)
{
   int NumberFour = (Number % 1000) / 100; 
  int Result = NumberFour;
  Console.WriteLine ($"число {Number} пятизначное, третья цифра  {Result}");
}