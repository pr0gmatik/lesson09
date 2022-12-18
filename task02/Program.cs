// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.WriteLine("введите количество строк");
int lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[lines, columns];
RandomNumbers(numbers);
PrintArray(numbers);

void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3} \t  ");
        }
        Console.WriteLine();
    }
}

int Sum = 0;
int sumLine = SumLines(numbers, 0);
for (int i = 1; i < numbers.GetLength(0); i++)
{
  int tempSumLine = SumLines(numbers, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    Sum = i;
  }
}

int SumLines(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

Console.WriteLine($"{Sum+1} - строкa с наименьшей суммой {sumLine} чисел ");