int a,b,c, max;

Console.WriteLine("Введите три числа:");

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
max = a;

if (b > max)
    max = b;
else
{
    if (c > max)
    max = c;
}   
Console.WriteLine("{0} максимальное число", max);