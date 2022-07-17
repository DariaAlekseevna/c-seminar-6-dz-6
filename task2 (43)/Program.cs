/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

int b1;
int k1;
int b2;
int k2;
Console.WriteLine("Введите значения b1, k1, b2 и k2:");
while ((!int.TryParse(Console.ReadLine(), out b1)) || (!int.TryParse(Console.ReadLine(), out k1)) || (!int.TryParse(Console.ReadLine(), out b2)) || (!int.TryParse(Console.ReadLine(), out k2)))
{
    System.Console.WriteLine("Введите корректные значения b1, k1, b2 и k2 заново:");
}

System.Console.WriteLine("прямые: y = " + k1 + " * x + " + b1+ ", y = "+ k2 + " * x + " + b2);

double x = 0;
double y = 0;
double b = 0;
double k = 0;

b = b2 - b1;
k = k1 - k2;
x = b/k;
y = k1 * x + b1;

System.Console.WriteLine("точка пересечения прямых равна: (" + x + "; " + y + ")");