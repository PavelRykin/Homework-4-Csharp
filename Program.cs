/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.WriteLine("Введите число ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("В какую степень возвести число " + a + "?");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Число " + a + " в степени " + b + " равно " + stepen(a, b));

int stepen(int a, int b)
{
    int answer = a;
    for (int i = 1; i < b; i++)
    {
        answer = answer * a;
    }
    return answer;
}
