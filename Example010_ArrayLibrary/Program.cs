void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] col) // void non-return method
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int [] array = new int[10]; //create new array with 10 elements; by default all elements would be 0. above to avoid all 0 in the array

FillArray(array);
PrintArray(array);
