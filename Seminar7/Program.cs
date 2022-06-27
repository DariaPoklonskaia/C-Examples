//Ex1 сгенерировать случайный массив на основании числе от пользователя.
/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];
    for(int i = 0; i < a; i++)
    {
        for (int j = 0; j<b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max +1); // строки, столбцы
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateRandomTwoDemArray(4,5,1,10);
*/

//Ex2 задать двумерный массив размером м и н; внутри элементы находятся по формуле i,j = i + j
/*
int[,] CreateRandomTwoDemArray(int m, int n)
{
    int[,] newMatrix = new int[m, n];
    for(int i = 0; i < m; i++)
    {
        for (int j = 0; j<n; j++)
        {
            newMatrix[i,j] = i+j; // строки, столбцы
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

Console.WriteLine("Input nb of rows");
int userM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input nb of columns");
int userN = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandomTwoDemArray(userM, userN);
*/

//Ex3 задать двумерный массив, найти элементы у которых оба индекса четные и заменить эти элементы на их квадраты
/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];
    for(int i = 0; i < a; i++)
    {
        for (int j = 0; j<b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max +1); // строки, столбцы
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}


int[,] ReplaceEvenSquare (int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i % 2 == 0 & j % 2 == 0)
                {
                    array[i,j] = array[i,j]*array[i,j];   
                    Console.Write(array[i,j] + " ");
                 }
                else Console.Write(array[i,j] + " ");
            }
        Console.WriteLine();
        }
        return array;
}

Console.WriteLine("Input nb of rows");
int userRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input nb of columns");
int userColmns = Convert.ToInt32(Console.ReadLine());

int max = 9;
int min = -10;

int[,] defineArray = CreateRandomTwoDemArray(userRows, userColumns, min, max);

Console.WriteLine();

ReplaceEvenSquare(defineArray);
*/
//Ex4  задать двумерный массив, найти сумму элементов на главной диагонали 

int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];
    for(int i = 0; i < a; i++)
    {
        for (int j = 0; j<b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max +1); // строки, столбцы
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int DiagonalSum (int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sum = 0;
    if (rows == columns)
        {
            for (int i = 0; i < rows; i++)
            {
                int j = i;
                sum += array[i,j];
            }
        }
    else Console.WriteLine("This method works only when nb of rows = nb of columns");
    return sum;
}

Console.WriteLine("Input nb of rows");
int userRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input nb of columns");
int userColmns = Convert.ToInt32(Console.ReadLine());

int max = 9;
int min = -10;

int[,] defineArray = CreateRandomTwoDemArray(userRows, userColmns, min, max);

Console.WriteLine("diagonal elements sum is " + CreateRandomTwoDemArray(defineArray));
