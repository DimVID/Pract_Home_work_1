// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
System.Console.WriteLine("введите первое число, num1 =");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число, num2 =");
int num2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите второе число, num3 =");
int num3 = Convert.ToInt32(Console.ReadLine());

int max_num = num1;
if (num1 < num2) 
{
    max_num = num2;
}
if (num2 < num3) 
{
    max_num = num3;
}
System.Console.WriteLine($"Максимальное число = {max_num}");
