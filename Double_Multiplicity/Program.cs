﻿/*Напишите программу, которая принимает на ввод число
и проверяет кратно ли оно одновременно 7 и 23
14 -> нет
46 -> нет
161 -> да*/
Console.Clear();
Console.WriteLine("Введите число:");
int a = int.Parse(Console.ReadLine());
if (a%7 == 0 && a%23 == 0)
{Console.WriteLine($"{a} -> да");}
else {Console.WriteLine($"{a} -> нет");}
