Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n / 100 < 1)
{
      Console.Write("В введенном числе нет третьей цифры.");
      break;
}
while (n / 10 > 100) 
{
            n = n/10;
}
while (n /100 > 1 || n/100 == 1)
{
      int m = n % 10;
      Console.Write($"Третья цифра введенного числа: {m}");
      break;
}




//Задача 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
