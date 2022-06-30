//Ex1 Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 

double[,] CreateRandomTwoDemDouble(int rows, int col, int min, int max)
{
    double[,] newArray = new double[rows, col];
    for(int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
            newArray[i,j] = new Random.NextDouble(min, max +1);

    return newArray;
}

void PrintTwoDemArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }
}

Console.WriteLine("Input nb of rows");
int userRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input nb of col");
int userCol = Convert.ToInt32(Console.ReadLine());

int defaultMin = -100;
int defaultMax = 100;

double[,] userArray = CreateRandomTwoDemDouble(userRows, userCol, defaultMin, defaultMax);
PrintTwoDemArray(userArray);

