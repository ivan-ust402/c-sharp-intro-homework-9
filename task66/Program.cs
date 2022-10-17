/* 
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Рекурсивно

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Clear();
Console.WriteLine("Для вывода суммы натуральных чисел в промежутке от M до N, ");
Console.Write("введите число M = ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("введите число N = ");
int N = int.Parse(Console.ReadLine()!);

if (N <= 0 || M <= 0)
{
    Console.WriteLine("Вы ввели не натуральные числа! Попробуйте снова!");
}
else 
{   
    int GetSum(int M, int N, int sum = 0) {
        if (M == N) {
            return sum;
        }
        else {
            sum = sum + M;
            return GetSum(M + 1, N, sum);
        }
    }

}