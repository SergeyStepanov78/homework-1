// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a != b)
{
    if (a > b)
    {
        Console.WriteLine("Min: " + b);
        Console.WriteLine("Max: " + a);
    }
    else
    {
        Console.WriteLine("Min: " + a);
        Console.WriteLine("Max: " + b);
    }
}
else
{
    Console.WriteLine("Введите, пожалуйста, разные числа");
}