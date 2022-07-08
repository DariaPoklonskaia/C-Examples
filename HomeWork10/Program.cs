// Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
/*
int CountWords(string[] arrayInput, char[] arrayVowels)
{
    int count = 0;
    for (int i=0; i < arrayInput.Length; i++)
        for(int j = 0; j < arrayVowels.Length; j++)
            {
                if (arrayInput[i].ToLower()[0] == arrayVowels[j]) count++;
            }
    return count;
}

string[] CreateStringArray(int size)
{
    string[] words = new string[size];
    for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine("Input " + (i+1) + "word");
            words[i] = Console.ReadLine();
        }

    return words;
}

char[] vowelsEng = {'a', 'e', 'i', 'o', 'u', 'y'}; 

Console.WriteLine("input how many words you want to check");
int userSize = Convert.ToInt32(Console.ReadLine());

string[] arrayUser = CreateStringArray(userSize);

Console.WriteLine(CountWords(arrayUser, vowelsEng));

*/
//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, 
// объединяя элементы исходного массива попарно

string[] MergeInParsElements(string[] array)
{
    string[] arrayAfterMerge = new string[(array.Length)/2];
    
    for(int i = 0; i < arrayAfterMerge.Length; i++)
        {
            arrayAfterMerge[i] = array[i*2] + array[(i*2) +1];
        }
    return arrayAfterMerge; 
}

void ShowArray(string[] array)
{
    for (int i=0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

string[] arrayToMerge = {"ab", "cd","ef", "gh", "ij"};

string[] resultArray = MergeInParsElements(arrayToMerge);

ShowArray(resultArray);




