// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом
//второго.

Console.WriteLine("Введите первое число :");
int namberN = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число :");
int namberM = int.Parse(Console.ReadLine());

Console.WriteLine("число" + namberN);
Console.WriteLine("число" + namberM);

Console.WriteLine("Квадрат числа: " + namberM * namberM);
if(namberN == namberM * namberM )
{
    Console.WriteLine("Первое число является квадратом второго числа =)");
}
else{
    Console.WriteLine("Первое число не является квадратом второго числа =(");
}