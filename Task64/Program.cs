// Задано значение N.
// написать программу, которая выведет все натуральные числа в промежутке от N до1.


Console.Write("Введите значение  N: ");
 int N = int.Parse(Console.ReadLine());

int i = N;

if (N>=1)
   
    for(i=N; i<=1; i--)
      {
        Console.Write($"{i}");
      }
   
Console.Write("В указанном промежутке нет натуральных чисел ");