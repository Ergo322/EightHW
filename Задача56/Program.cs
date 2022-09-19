Console.WriteLine("Задайте количество строк двумерного массива:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

void CreationArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int SumNum(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

void SearchSum()
{
    int MinSumLine = 0;
    int sumLine = SumNum(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempSumLine = SumNum(array, i);
        if (sumLine > tempSumLine)
        {
            sumLine = tempSumLine;
            MinSumLine = i;
        }
    }
    Console.WriteLine($"\n{MinSumLine + 1} - строка с наименшей суммой");
}

CreationArray(array);
Console.WriteLine();
PrintArray(array);
SearchSum();