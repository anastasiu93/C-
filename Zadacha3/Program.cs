// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

int WeekDays = int.Parse(Console.ReadLine());

if (WeekDays == 1)
{
    Console.WriteLine("Monday");
}
else if (WeekDays == 2)
{
    Console.WriteLine("Tuesday");
}
else if (WeekDays == 3)
{
    Console.WriteLine("Wednesday");
    }
else if (WeekDays == 4)
{
    Console.WriteLine("Thursday");
}
else if (WeekDays == 5)
{
    Console.WriteLine("Friday");
}
else if (WeekDays == 6)
{
    Console.WriteLine("Saturday");
}
else if (WeekDays == 7)
{
    Console.WriteLine("Sunday ");
}
else
{
  Console.WriteLine("error");  
}