/*
// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Input first number:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
  Console.WriteLine($"{0} is max number {a}");
  else
  Console.WriteLine($"{0} is max number {b}");
*/
/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Input first number:");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input third number:");
int w = Convert.ToInt32(Console.ReadLine());
if (y>x)
 Console.WriteLine($"{y} is max number:");
 else
 Console.WriteLine($"{x} is max number:");
 if (w>y)
 Console.WriteLine($"{w} is max number:");
else
 Console.WriteLine($"{y} is max number:");
 if (w>x)
  Console.WriteLine($"{w} is max number:");
  else
   Console.WriteLine($"{x} is max number:");
   */

   
   // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
   Console.WriteLine("Input the number:");
 int n = Convert.ToInt32(Console.ReadLine());
 int even = n / 2;
 if (even == 2)
 Console.WriteLine($"{n} is yes even");
  else
  Console.WriteLine($"{n} is not even");
  
 


