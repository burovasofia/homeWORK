int num1, num2, num3;

Console.WriteLine("Введите первое число");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("максимальное число " + num1);
    if(num1 > num3)
     {
Console.WriteLine("максимальное число " + num1);
     }
    else
    {
        Console.WriteLine("максимальное число " + num3);
    }
}
else
{
    if(num2 > num3)
    {
        Console.WriteLine("максимальное число " + num2);
    }
    else
    {
        Console.WriteLine("максимальное число " + num3);
    }
}
