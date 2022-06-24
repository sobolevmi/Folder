// Вывести на экран все четные числа от 1 до N
Console.WriteLine ("Введите число: ");
int number = Convert.ToInt32 (Console.ReadLine ());
int i = 1;
Console.Write (number + " -> ");
while (i <= (number-2))
{
    if (i % 2 == 0)
    {
        Console.Write (i + ", ");
    }
    i++;
}
while (i <= number)
{
    if (i % 2 == 0)
    {
        Console.Write (i);
    }
    i++;
}