﻿Console.WriteLine ("Введите первое число");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число");
int b = Convert.ToInt32 (Console.ReadLine());
if (a > b) 
{
    Console.WriteLine ("a = " + a + "; b = " + b + " -> max = " + a);
}
else
{
    Console.WriteLine ("a = " + a + "; b = " + b + " -> max = " + b);
}