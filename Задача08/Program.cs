//Задача 8: Напишите программу, 
//которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.Clear();

Console.Write("Введите номер: ");

int n = int.Parse(Console.ReadLine());

int [] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

int nummer = 2;

if (n > 1)
{
    while (nummer <= n)
    {
      Console.WriteLine (nummer);
      nummer = nummer + 2;
    }

}
    