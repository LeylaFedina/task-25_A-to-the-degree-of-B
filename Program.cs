﻿/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(userNumber > 0)
{
userNumber = userNumber / 10;
count++;
}
Console.WriteLine(count);


/* Идеальное решение
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
userNumber = Math.Abs(userNumber);
int result = 1;
if(userNumber != 0)
{
    result = (int)Math.Log10(userNumber) + 1;
}
Console.WriteLine($"Количество знаков в числе {result}");
*/

Console.Clear();  
int getResult (string userInformation)
{
    int result = 0;
    Console.Write($"{userInformation} ");
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 1)
    {
        Console.Write($"Ошибка ввода! Введите целое число больше единицы. {userInformation} ");
    }
    return result;
}

int userNumber1 = getResult("Number 1 = ");
int userNumber2 = getResult("Number 2 = ");

double findResult (int Number1, int Number2)
{
    return Math.Pow(Number1, Number2);
}
Console.WriteLine(findResult(userNumber1, userNumber2));

