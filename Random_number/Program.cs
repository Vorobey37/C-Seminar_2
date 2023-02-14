/*Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа*/

Console.Clear();
int a = new Random().Next(10, 100); //Первое число включается, а второе нет! "[)"
Console.WriteLine(a);
int b = a/10;
int c = a%10;
int max = b;
if (c>max)
{max = c;}
Console.WriteLine(max);
