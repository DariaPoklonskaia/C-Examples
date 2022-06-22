//Ex1 найти кол-во четных элементов массива
/*
int[] CreteRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int FindEvenNumbered(int[] array)
{
    int size = array.Length;
    int count = 0;
    for(int i = 0; i < size; i++)
    {
        if (array[i]% 2 == 0) count++;
    }
    return count;
}

int[] myArray =  CreteRandomArray(10, 100, 999);

Console.WriteLine("there are " + FindEvenNumbered(myArray) + " even-numbered elements");

*/

//ex2 найти сумму элементов стоящих на нечетных позициях
/*
int[] CreteRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max+1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int FindSumUnevenPosotion(int[] array)
{
    int size = array.Length;
    int sum = 0;
    for(int i = 1; i < size; i= i+2)
    {
        sum += array[i];
    }
    return sum;
}

int[] myArray =  CreteRandomArray(10, -100, 100);

Console.WriteLine("Sum of elements on uneven positions is " + FindSumUnevenPosotion(myArray));

*/
// Ex3 Создать массив с вещественными числами и найти разницу между макс и мин

double[] CreteRandomArray(int size)
{
    double[] newArray = new double[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble();
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

double FindMax(double[] array)
{
    double max = array[0];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (max < array[i]) max = array[i]; 
    }
    return max;
}

double FindMin(double[] array)
{
    double min = array[0];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (min > array[i]) min = array[i]; 
    }
    return min;
}

double[] myArray = CreteRandomArray(5);
double difference = FindMax(myArray) - FindMin(myArray);

Console.WriteLine("Difference b/w mam and min is " + difference);
