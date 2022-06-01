/*
Задача 43. Напишите программу, которая найдёт точку пересечения 
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 0,5)

решаем систему уравнений:
|y = k1*x+b1     |y-y=k1x+b1-k2x-b2    |0=k1x-k2x-b2+b1    |k2x-k1x=b1-b2    |x=(b1-b2)/(k2-k1)
|             => |                  => |                => |              => |
|y = k2*x+b2     |y=k2x+b2             |y=k2x+b2           |y=k2x+b2         |y=k2x+b2  
(кошмар! как тяжело вспоминается математика)
*/



Console.WriteLine("Введите параметр b1");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите параметр k1");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите параметр b2");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите параметр k2");
double k2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2)
    {
        Console.WriteLine("Прямые параллельны");
    }

    else
    {
        double x = ((b1 - b2) / (k2 - k1));
        double y = (k2 * x + b2);
        Console.WriteLine($"Точка пересечения прямых: [{Math.Round(x, 2)}, {Math.Round(y, 2)}].");
    }
    