// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100) Console.Write("Третьей цифры нет");
if (num >= 100 && num < 1000) Console.Write($"Третья цифра заданного числа: {num % 10}");
if (num >= 1000)
{
    {
        while (num > 1000)
            num = num / 10;
    }
    Console.Write($"Третья цифра заданного числа: {num % 10}");
}