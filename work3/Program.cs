int num;

Console.WriteLine("Введите число");
num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("число четное");
}
else
{
    Console.WriteLine("число не четное");
}