// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = ReadInt("Введите трехзначное число: ");
int amount = num.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("не трехзначное число");
}
else
{
    Console.WriteLine(Two(num));
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Two(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}