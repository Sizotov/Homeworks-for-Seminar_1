//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите номер: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второй номер: ");
int b = int.Parse(Console.ReadLine());

int Max (int a, int b)

{
  int result = a;
  if (b > result) result = b;
  return result;
} 

Console.WriteLine($"max ={Max (a, b)}");
