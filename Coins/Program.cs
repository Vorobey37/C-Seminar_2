/*На столе лежит некоторое количество монеток, некоторые повернуты орлом, некоторые решкой.
Необходимо определить минимальное количество монеток, которое нужно перевернуть,
чтобы все монетки были повернуты вверх одной стороной*/
Console.Clear();
int a = new Random().Next(1, 10);
int []b = new int [a];
for (int i = 0; i<a; i++)
{b[i] = new Random().Next(0, 2);
Console.Write($"{b[i]} ");}
Console.WriteLine();
/*for (int i = 0; i<a; i++)
{Console.Write($"{b[i]} ");}*/

int i1 = 0;
int c1 = 0;
int c2 = 0;

while (i1<a)
{
    if (b[i1]==0)
    {c1++;}
    else {c2++;}
    i1++;
}
int min = c1;
if (c2<min)
{min = c2;}
Console.WriteLine(min);


