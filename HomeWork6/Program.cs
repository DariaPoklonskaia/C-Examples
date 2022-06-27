//Ex 1 пользователь вводит числа, надо выяснить сколько там числе больше нуля

int CountPositive(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


int[] StringToArray(string text)
{
    int lenght = text.Length;
    int[] arrayUser = new int[lenght];
    
    for (int i = 0; i<lenght; i++)
    {
        while (text[i] != " ")
        {
            string devideToNums = devideToNums + text[i]; 
            arrayUser[i] = Convert.ToInt32(devideToNums);
            Console.Write(arrayUser[i] + " ");
        }
        
        
    }
    return arrayUser;
}


Console.WriteLine("input m numbers");
string textUser = Console.ReadLine();

StringToArray(textUser);

// Console.WriteLine(CountPositive(userArray));
