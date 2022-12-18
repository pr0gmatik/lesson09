// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine("введите количество строк первой таблицы:");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов первой таблицы:");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество строк второй таблицы:");
int lines2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов второй таблицы:");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines, columns];
int[,] numbers2 = new int[lines2, columns2];
int[,] resMatrix = new int[lines, columns2];
Console.WriteLine("Первая таблица: ");
RandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine("Вторая таблица: ");
RandomNumbers(numbers2);
PrintArray(numbers2);

if (columns != lines2)
{
    Console.WriteLine("ОШИБКА!!!   Количество столбцов в 1-й таблицы должно равняться количеству строк во 2-й таблице!");
}
else
{
    EndTable(numbers, numbers2, resMatrix);
    Console.WriteLine("Произведение первой и второй матриц:");
    WriteArray(resMatrix);
}

void RandomNumbers(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-99, 100);
        }
    }
}

void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],3} \t  ");
        }
        Console.WriteLine();
    }
}

void EndTable(int[,] numbers, int[,] numbers2, int[,] resMatrix)
{
    for (int i = 0; i < resMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < numbers.GetLength(1); k++)
            {
                sum += numbers[i, k] * numbers2[k, j];
            }
            resMatrix[i, j] = sum;
        }
    }
}



void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],5}\t ");
        }
        Console.WriteLine();
    }
}