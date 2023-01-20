// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.Write("Введите число а ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число c ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;

if (b > a)
max = b;
if (c > b)
max = c;
Console.Write($"max = {max}");
