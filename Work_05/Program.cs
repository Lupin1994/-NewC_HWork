﻿// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Веди трехзначное число: ");
int Num = int.Parse(Console.ReadLine() ?? "");
int Num_3 = Num % 10;
Console.WriteLine($"Третье число = {Num_3}");