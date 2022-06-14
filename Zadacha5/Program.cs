// Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число : ");

int numberX = int.Parse(Console.ReadLine());

Console.WriteLine(numberX % 10);