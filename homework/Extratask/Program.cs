Console.Clear();

int n = Convert.ToInt32(Console.ReadLine());
int max = 0;
int premax = 0;
while (n != 0)
{
    if (n>max)
{
    premax = max;
    max = n;
}
else
{
    if (n>premax)
    premax = n;
}
n = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("end");
Console.Write($"Второе максимальное число: {premax}");







               