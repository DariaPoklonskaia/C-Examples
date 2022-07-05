// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по возрастанию элементы каждой строки двумерного массива
/*
int[,] CreateTwoDemArray (int m, int n, int min, int max)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(min, max +1);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] ArrayBubleSorting(int[,] array)
{
    int temp;
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1 - k; j++)
            {
                if (array[i,j] > array[i, j+1])
                {
                        temp = array[i,j];
                        array[i,j] = array[i, j+1];
                         array[i, j+1] = temp;
                }
            }
        }
    }
    return array;
}

Console.WriteLine("Input nb of rows");
int userRow = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input nb of columns");
int userCol = Convert.ToInt32(Console.ReadLine());


int[,] userArray = CreateTwoDemArray(userRow, userCol, -9, 9);

PrintArray(userArray);

Console.WriteLine("After buble sorting array looks like that:");

ArrayBubleSorting(userArray);

PrintArray(userArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов
/*
int[,] CreateTwoDemSquareArray (int m, int min, int max)
{
    int[,] array = new int[m,m];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i,j] = new Random().Next(min, max +1);

    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int ArrayRowsMaxSum(int [,] array)
{
    int maxSum = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (sum > maxSum) maxSum = sum;
        sum = 0;
    }
    return maxSum;
}

Console.WriteLine("Input nb of rows and columns");
int userRowColumn = Convert.ToInt32(Console.ReadLine());

int[,] randomArray = CreateTwoDemSquareArray(userRowColumn, 0, 9);

PrintArray(randomArray);

Console.WriteLine("Rows max sum is " + ArrayRowsMaxSum(randomArray));

*/

//  Задача 62. Заполните спирально массив 4 на 4