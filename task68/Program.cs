/* 
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
Console.Clear();
Console.WriteLine("Для вычисления функции Аккермана введите два неотрицательных целых числа.");
Console.Write("m = ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("n = ");
int n = int.Parse(Console.ReadLine()!);

if (m < 0 || n < 0)
{
    Console.WriteLine("Вы ввели отрицательные или не целые числа! Попробуйте снова!");
}
else 
{
    int GetAkkerman(int m, int n) {
        if (m = 0) 
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return GetAkkerman(m - 1, 1);
        }
        else {
            return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
        }
    }
}