/*
string[] names = {"Ivan", "Anna", "Max", "Denis"};

Console.WriteLine(names[1]); // выдаст Анна

Console.WriteLine(names[0][1]); //обратится так к конкретной букве в каждом слове
*/
// Ex1 метод на вход берет слова, возвращает кол-вл слов, длина которых больше 5 букв
/*
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int NumberOfLongWords(string[] array)
{
    int count = 0; 

    for(int i=0; i < array.Length; i++)
        if(array[i].Length >=5)
            count++;

    return count;
}

Console.Write("input nb of names");
int size = Convert.ToInt32(Console.ReadLine());
string[] names = CreateStringArray(size);

Console.WriteLine("Nb of long words is " + NumberOfLongWords(names));

*/

//Ex2 принимает на вход два массива строк и возвращает их попарно объединенных

string[] MergeArray(string[] array1, string[] array2) // лучше все объединять в наибольший массив и не создавать новый, 
{
    int size;
    if (array1.Length < array2.Length)
    {
        size = array1.Length;
        for (int i = 0; i < size; i++)
        {
            array1[i] = array1[i] + " " + array2[i]; 
        }
        return array1;
    }

    else
    {
        size = array2.Length;
        for (int i = 0; i < size; i++)
        {
            array2[i] = array1[i] + " " + array2[i]; 
        }
        return array2;
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] array1user = {"Ivan", "Anna", "Max", "Denis"};

string[] array2user = {"1", "2", "3", "4", "5"};

string[] unitedArray = MergeArray(array1user, array2user);
ShowArray(unitedArray);



// программа, которая считает количество строк которые начинаются на буквы Y или W
/*
int CountWords(string[] array, char a, char b) // при работе с символами и элементами строки используется char 
{
    int count = 0; 
    for (int i = 0; i < array.Length; i++)
        {
            if(array[i].ToLower()[0] == a || array[i].ToLower()[0] == b)
            count++;
        }
return count;
}

char aUser = 'y'; // символы чар в одинарных кавычках
char bUser = 'w';

string [] array1user = {"Yvan", "Wnna", "Max", "Denis"};

Console.WriteLine(CountWords(array1user, aUser, bUser));

// char a = Convert.ToChar(Console.ReadLine());
*/

