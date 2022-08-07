/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

Console.WriteLine("Введите число ");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Сумма цифр в числе равно " + findSumm(number));

int findSumm(int a)
{
    int counter = Convert.ToString(a).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = a - (a % 10);
        result = result + (a - advance);
        a = a / 10;
    }
    return result;
}



