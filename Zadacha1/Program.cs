//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine(" Введите число :");

int n = int.Parse(Console.ReadLine()); // оброзует в целое число, а не в строчку(Console.ReadLine()

Console.WriteLine("Число :" + n); // сразу встает в одной строке

Console.WriteLine("Квадрат числа :" + n * n);