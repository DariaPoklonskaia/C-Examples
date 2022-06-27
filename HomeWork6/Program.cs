//Ex 1 пользователь вводит числа, надо выяснить сколько там чисел больше нуля
/*
int CountPositive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] FillArrayByUser(int size)
{
    int[] array = new int[size];
    for (int i = 0; i <size; i++)
    {
        Console.WriteLine("Input " + (i+1) + " number");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


Console.WriteLine("input how many numbers you want to type");
int userSize = Convert.ToInt32(Console.ReadLine());

int[] userArray = FillArrayByUser(userSize);

Console.WriteLine("There are " + CountPositive(userArray) + " positive numbers");

*/

// Ex2 Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования
/*
int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
        Console.Write(copyArray[i] + " ");
    }
    return copyArray;
}

int[] sourseArray = new int[6]{1, 2, 5, -8, 6, 50};

CopyArray(sourseArray);

*/

// далее попытка для первой задача преобразовать , записанные строкой пользователем цифры, в массив. 
int[] StringToArray(string text)
{
    int lenght = text.Length;
    int[] arrayUser = new int[lenght];
    
    for (int i = 0; i<lenght; i++)
    { 
        arrayUser[i] = Convert.ToInt32(text[i]);
        Console.Write(arrayUser[i] + " ");
    }
    return arrayUser;
}


Console.WriteLine("input m numbers");
string textUser = Console.ReadLine();

StringToArray(textUser);




