﻿/*Напишите программу, которая будет принимать на вход два числа 
и выводить, является ли второе кратным первому. Если число не является
кратным, то выводит остаток от деления
34, 5 -> не кратно, остаток 4
16, 4 -> кратно*/
Console.Clear();
Console.WriteLine("Введите первое число:");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = int.Parse(Console.ReadLine());
if (a%b == 0)
{Console.WriteLine($"{a}, {b} -> кратно");}
else {Console.WriteLine($"{a}, {b} -> не кратно, остаток {a%b}");}