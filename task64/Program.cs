/* 
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Clear();
Console.WriteLine("Для вывода всех натуральных чисел от N до 1, ");
Console.Write("введите число N = ");
int N = int.Parse(Console.ReadLine()!);
if (N <= 0)
{
    Console.WriteLine("Вы ввели не натуральное число! Попробуйте снова!");
}
else 
{   
    int[] arrayOfIntegers = new int[N];
    int[] array = GetIntegers(arrayOfIntegers, N); 
    PrintArray(array);


    int[] GetIntegers(int[] array, int N, int count = 0) 
    {
        if (count + 1 == N) {
            array[count] = 1;
        }
        else
        {   
            array[count] = N - count;
            GetIntegers(array, N, count + 1);
        }
        return array;
    }
    
    void PrintArray(int[] array) {
        for (int i = 0; i < array.Length; i++) 
        {
            if (i == 0 && array.Length > 1) 
            {
                Console.Write($"[{array[i]}, ");
            } 
            else if (i == array.Length - 1 && array.Length > 1) 
            {
                Console.Write($"{array[i]}]");
            } 
            else if (i == 0 && array.Length <= 1) 
            {
                Console.Write($"[{array[i]}]");
            }
            else 
            {
                Console.Write($"{array[i]}, ");
            }
        }
        Console.WriteLine("");
    }
}

