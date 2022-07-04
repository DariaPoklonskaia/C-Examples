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

int[,] CreateTwoDemSquareArray (int m, int max, int min)
{
    int[,] array = new int[m,m];
    for (int i=0; i < m; i++)
            for (int j=0; j < m; j++)
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
            for (int j =0; j < array.GetLength(1); j++)
            {
                array[i,j] = temp;
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
        return array;
    }
    else Console.WriteLine("This method works only for square matrix");
    return array;
    
}
//Ex3 из двумерного массива целых чисел удалить строку и столбец (заменить на 0),
// на пересечении которых расположен наименьший элемент.