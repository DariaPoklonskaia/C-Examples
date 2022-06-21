//массив из 12 чисел заполненный произвольно от -9 до 9. Найти сумму отрицательных и сумму положительных
/*
int[] CreateRandomArray(int size, int min, int max)
{
int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}


int FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}

int[] myArray = CreateRandomArray(12, -9, 9);

Console.WriteLine("Positive sum is" + FindPositiveSum(myArray));

Console.WriteLine("Negative sum is" + FindNegativeSum(myArray));

*/ 

// Ex2 программа заменов элементов массива. положительные заменить на  отрицательные ( 5 на -5 и наоборот). 
/*
int[] CreateRandomArray(int size, int min, int max)
{
int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int[] RevertArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = -1 * array[i];
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    return array;
}

int[] myArray = CreateRandomArray(10, -10, 10);

int[] revertArray = RevertArray(myArray); 
*/
// Ex3 задать массив и написать программу, которая определяет присутствует ли заданное число в массиве. 
/*
int[] CreateRandomArray(int size, int min, int max)
{
int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

void CheckNumberPresent(int[] array, int num)
{
    for(int i = 0; i < array.Length; i++)
        {
            if (array[i] == num) Console.Write(i + " ");
            
        }
      
}

int[] myArray = CreateRandomArray(10, -5, 5);

Console.WriteLine("input value to find");
int userNum = Convert.ToInt32(Console.ReadLine());

CheckNumberPresent(myArray, userNum); 

*/

//Ex4 Задать одномерный массив из 12 случ чисел, найти количество элементов,  
// значения которых в отрезке от 10 до 99 включительно 

int[] CreateRandomArray(int size, int min, int max)
{
int[] newArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;
}

int CountNumbersInRange(int[] array, int min, int max)
{
 int count = 0;
 for(int i = 0; i < array.Length; i++)
        {
            if (array[i] >= min && array[i] <= max) count++;
        }
return count;
}

int[] myArray = CreateRandomArray(12, -100, 100);
int CountNumers = CountNumbersInRange(myArray, 10, 99);

Console.WriteLine(CountNumers);