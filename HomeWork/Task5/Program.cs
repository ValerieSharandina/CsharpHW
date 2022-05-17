/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int randomNumber = new Random().Next(100, 1000); 

int numberOne = randomNumber % 10; 
int numberTwo = randomNumber % 100; 
int Result = (numberTwo - numberOne) / 10; 

Console.WriteLine (randomNumber);
Console.WriteLine ($" Число {randomNumber}  Результат {Result}");

