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

void PorydokArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int g = 0; g < array.GetLength(1) - 1; g++)
            {
                if (array[i, g] < array[i, g + 1])
                {
                    int temp = array[i, g + 1];
                    array[i, g + 1] = array[i, g];
                    array[i, g] = temp;
                }
            }
        }
    }
}

CreationArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Отсортированый массив");
Console.WriteLine();
PorydokArray(array);
PrintArray(array);