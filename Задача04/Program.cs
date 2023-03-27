//Напишите программу, которая 
//принимает на вход три числа и
//выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Clear();

Console.Write("Введите номер: ");

int a = int.Parse(Console.ReadLine());

Console.Write("Введите второй номер: ");

int b = int.Parse(Console.ReadLine());

Console.Write("Введите третий номер: ");

int с = int.Parse(Console.ReadLine());

int Max (int a, int b, int c)

{
  int result = a;
  if (b > result) result = b;
  if (c > result) result = c;
  return result;
} 

Console.WriteLine($"max ={Max (a, b, c)}");
