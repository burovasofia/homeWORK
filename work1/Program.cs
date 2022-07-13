int num1, num2;

Console.WriteLine("Введите первое число");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("max = num1, min = num2");
}
else
{
    Console.WriteLine("max = num2, min = num1");
}