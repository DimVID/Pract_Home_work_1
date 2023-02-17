// Задача 4: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
System.Console.WriteLine("введите число, num =");
int num = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count <= num)
{
    System.Console.WriteLine(count);
    count += 2;
}