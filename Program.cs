﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine ("Введите число от 1 до 7:");
int number1 = Convert.ToInt32(Console.ReadLine());

if(number1 == 6 || number1 == 7)
{
    Console.WriteLine("Да, этот день является выходным");
}
else
{
    Console.WriteLine("Нет, этот день не является выходным");
}