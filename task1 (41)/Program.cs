/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */


void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write("введите элемент массива:");
         array[index] =  int.Parse(Console.ReadLine());
        index++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
     {
        if (position == 0 && (count - 1) == 0)
        {
            Console.WriteLine("[" + array[position] + "]");
        }
        else if (position == 0)
        {
            Console.Write("[" + array[position] + ", ");
        }
        else if (position == (count - 1))
        {
            Console.WriteLine(array[position] + "]");
        }
        else
        {
            Console.Write(array[position] + ", ");
        }
        position++;
    }
}



int M;
Console.WriteLine("Введите количество чисел:");
while (!int.TryParse(Console.ReadLine(), out M))
{
    System.Console.WriteLine("Введите корректное значение:");
}

int[] array = new int [M];

FillArray(array);
Console.WriteLine("массив заданный пользователем:");
PrintArray(array);

int sum = 0;
int i = 0;
while (i < M)
{
    if (array[i] > 0)
    {
        sum++;
    }
    i++;
}

System.Console.WriteLine(" чисел больльше 0: " + sum);