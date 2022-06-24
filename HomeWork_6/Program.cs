// Проверить, является ли число четным
Console.WriteLine ("Введите число");
double number = Convert.ToDouble (Console.ReadLine ());
if (number %2 == 0)
{
Console.WriteLine (number + " -> " + "да");
}
else
{
Console.WriteLine (number + " -> " + "нет");
}