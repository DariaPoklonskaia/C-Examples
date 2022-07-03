//Ex1 Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. 
/*
double[,] CreateRandomTwoDemDouble(int rows, int col, int min, int max)
{
    double[,] newArray = new double[rows, col];
    for(int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i,j] = new Random().NextDouble()*(max - min);
            newArray[i,j] = min + newArray[i,j];
        }
            

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

*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
//значение этого элемента или же указание, что такого элемента нет.
/*
int[,] CreateRandomTwoDem(int rows, int col, int min, int max)
{
    int[,] newArray = new int[rows, col];
    for(int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i,j] = new Random().Next(min, max + 1);
            newArray[i,j] = min + newArray[i,j];
        }
            

    return newArray;
}

void PrintTwoDemArray(int[,] array)
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

void ViewElementValue (int indexRow, int indexCol, int[,] array)
{
if (indexRow >= 0 && indexRow < array.GetLength(0) && indexCol >= 0 && indexCol<array.GetLength(1))
    Console.WriteLine("Element value is " + array[indexRow,indexCol]);

else Console.WriteLine("there are no such element");
}

int defaultMin = -100;
int defaultMax = 99;
int defaultRows = 10;
int defaultCol = 10;

int[,] testArray = CreateRandomTwoDem(defaultRows, defaultCol, defaultMin, defaultMax);

Console.WriteLine("Input row position from 0 to " + testArray.GetLength(1));
int userRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input col position from 0 to " + testArray.GetLength(1));
int userCol = Convert.ToInt32(Console.ReadLine());

ViewElementValue(userRows, userCol, testArray);

Console.WriteLine();

PrintTwoDemArray(testArray);

*/

//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRandomTwoDem(int rows, int col, int min, int max)
{
    int[,] newArray = new int[rows, col];
    for(int i = 0; i < newArray.GetLength(0); i++)
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i,j] = new Random().Next(min, max + 1);
            newArray[i,j] = min + newArray[i,j];
        }
            

    return newArray;
}

void PrintTwoDemArray(int[,] array)
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

double FindColumnAverage(int[,] array)
{
    double average = 0; 
     
}