// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
System.Console.WriteLine("введите первое число, num1 =");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число, num2 =");
int num2 = Convert.ToInt32(Console.ReadLine());

int max_num = 0;
int min_num = 0;
if (num1 > num2)
{
    max_num = num1;
    min_num = num2;
}
else
{
    max_num = num2;
    min_num = num1;
}
System.Console.WriteLine($"Максимальное число = {max_num}, минимальное число = {min_num}");
