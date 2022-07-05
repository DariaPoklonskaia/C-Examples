//Ex1 задать двумерный массив, и поменять местами первую и последнюю строки
/*
int[,] CreateTwoDemArray (int m, int n, int max, int min)
{
    int[,] array = new int[m,n];
    for (int i=0; i < m; i++)
            for (int j=0; j < n; j++)
                array[i,j] = new Random().Next(min, max +1);
        
    return array;
}

void PrintTwoDemArray(int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }      
            
}

int[,] ChangeLines(int[,] array, int srtIndex1, int strIndex2)
{
    int temp;
    for(int j=0; j < array.GetLength(1); j++)
    {
        temp = array[srtIndex1,j];
        array[srtIndex1,j] = array[strIndex2,j];
        array[strIndex2,j] = temp;
    }
    return array;
}

int[,] myArray = CreateTwoDemArray(4,5,9,1);
PrintTwoDemArray(myArray);

myArray = ChangeLines(myArray, 0, myArray.GetLength(0)-1);
Console.WriteLine();

PrintTwoDemArray(myArray);
*/
// перегрузка метода: перечень входящих аргументов отличается, чтобы была возможность отправлять разные аргументы.

//Ex2 двумерный массив, замена строк на столбцы и сообщить, если это невозможно.
/*
int[,] CreateTwoDemSquareArray (int m, int n, int max, int min)
{
    int[,] array = new int[m,n];
    for (int i=0; i < m; i++)
            for (int j=0; j < n; j++)
                array[i,j] = new Random().Next(min, max +1);
        
    return array;
}

void PrintTwoDemArray(int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }      
            
}

int[,] TransponeArray(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int temp;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j =0; j < i; j++)
            {
                temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
        
    }
    else Console.WriteLine("This method works only for square matrix");
    
    return array;
}


Console.WriteLine("Input nb of rows");
int userRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input nb of columns");
int userCol = Convert.ToInt32(Console.ReadLine());

int[,] userArray = CreateTwoDemSquareArray(userRows, userCol, 10, 0);

PrintTwoDemArray(userArray);

Console.WriteLine();

TransponeArray(userArray);

PrintTwoDemArray(userArray);
*/
//Ex3 из двумерного массива целых чисел удалить строку и столбец (заменить на 0),
// на пересечении которых расположен наименьший элемент.

int[,] CreateTwoDemSquareArray (int m, int n, int max, int min)
{
    int[,] array = new int[m,n];
    for (int i=0; i < m; i++)
            for (int j=0; j < n; j++)
                array[i,j] = new Random().Next(min, max +1);
        
    return array;
}

void PrintTwoDemArray(int[,] array)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j=0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }      
            
}

int[] FindIndexes(int[,] array)
{
    int min = array[0,0];
    int size = 2;
    int[] indexArray = new int[size];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] < min) min = array[i,j]; 
            indexArray[0] = i;
            indexArray[1] = j;
        }
    }
    return indexArray;
}

int[,] ChangeLinesToZero (int [,] arrayToModify, int[] arrayWithIndexes)
{
    for (int i = 0; i < arrayToModify.GetLength(0); i++)
    {
        int j = arrayWithIndexes[1];
        arrayToModify[i,j] = 0;
    }

    for (int j=0; j < arrayToModify.GetLength(1); j++)
    {
        int i = arrayWithIndexes[0];
        arrayToModify[i,j] = 0;
    }

    return arrayToModify;
}

Console.WriteLine("Input nb of rows");
int userRows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input nb of columns");
int userCol = Convert.ToInt32(Console.ReadLine());

int[,] userArray = CreateTwoDemSquareArray(userRows, userCol, 9, 0);

PrintTwoDemArray(userArray);

Console.WriteLine();

int[] indexes= FindIndexes(userArray); 

ChangeLinesToZero(userArray, );
