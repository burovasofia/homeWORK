int num;
Console.Write("Введите число ");
num = Convert.ToInt32(Console.ReadLine());
int current = 1;
while (current <= num)
{
 if(current % 2 == 0)
    {
        Console.Write(current + " ");
    }
    else
    {
    }
    current = current + 1;
}

