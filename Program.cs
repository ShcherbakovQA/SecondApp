
Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, являющееся квадратом первого числа ");
int b = Convert.ToInt32(Console.ReadLine());
if (b == a*a)
{
    Console.WriteLine("Правильно, это квадрат числа! ");
}
else 
{
    Console.WriteLine("Неверный ответ ");
}
