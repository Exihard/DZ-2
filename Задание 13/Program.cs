// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine ("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

if (num <= 99)
{
    Console.WriteLine("В заданном числе нет третьей цифры!");
}
else
{
   while (num > 999)
   {
    num /= 10;
   }
   Console.WriteLine(num % 10);
}

