/*
Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
*/
Console.Write ("Введите первое число:  ");
int Number1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число:  ");
int Number2 = Convert.ToInt32(Console.ReadLine());

int max = 0;
if (Number1 > Number2)
{
    Console.WriteLine(max = (Number1));

}
if (Number1 == Number2)
{
    Console.WriteLine("числа равны");
}
if (Number1 < Number2)
{
    Console.WriteLine(max = (Number2));
}


