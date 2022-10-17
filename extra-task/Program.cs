/* 
Доп задача
Заданы 2 массива: info и data. В массиве data хранятся двоичные представления нескольких чисел (без разделителя). В массиве info хранится информация о количестве бит, которые занимают числа из массива data. Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
входные данные: data = {0, 1, 1, 1, 1, 0, 0, 0, 1 } info = {2, 3, 3, 1 }выходные данные: 1, 7, 0, 1
*/

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1};
int[] info = {2, 3, 3, 1};
Console.WriteLine("Массив data: ");
PrintArray(data);
Console.WriteLine("Массив info: ");
PrintArray(info);

int[] result = numberArray(data, info);
Console.WriteLine("В результате числа в десятичной системе счисления: ");
PrintResult(result);


int[] numberArray(int[] data, int[] info) {
    int index = 0;
    int[] result = new int[info.Length];
    for (int i = 0; i < info.Length; i++)
    {
        int[] num = new int[info[i]];

        for (int j = 0; j < num.Length; j++)
        {
            num[j] = data[index];
            index++;
        }
        result[i] = ToDec(num);
    }
    return result;
}

int ToDec(int[] array) {
    int sum = 0;
    int degree = 0;
    for (int i = array.Length - 1; i >= 0; i--)
    {
        sum = sum + array[i] * (int)Math.Pow(2, degree);
        degree++;
    }
    return sum;
}

void PrintResult(int[] array){
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
    Console.WriteLine();
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
        Console.WriteLine();
    }
