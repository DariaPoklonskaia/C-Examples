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
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0; 
    int position = -1; //if there is no such element, -1 would be interpreted as such element is not founded. 

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break; 
        }
        index++;
    }
    return position;
}

int [] array = new int[10]; //create new array with 10 elements; by default all elements would be 0. above to avoid all 0 in the array

FillArray(array); // call method to fill array
array[4] = 4;
array[6] = 4;
PrintArray(array); // call method to print 
Console.WriteLine();

int pos = IndexOf(array,4);
Console.WriteLine(pos);