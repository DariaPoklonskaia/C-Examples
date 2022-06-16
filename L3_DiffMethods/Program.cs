// Different methods

// Вид1

void Method1();
{
    Console.WriteLine("Author...");

}

Method1();


//type2 

void Method2 (string msg)
{
    Console.WriteLine(msg);
}

Method2("Message text");


//type 3


int Method3();
{
    return DateOnly.FromDateTime.Now.Year;
}

int year =Method3();
Console.WriteLine(year);

// Type 4 

string Method4 (int count, char c);
{
    int i = 0;
    string result = string.Empty; // string = ""'
    while (i < count) 
        {
            result = result + c;
            i++;
        } 
        return result;
}

string res = Method4(10, "acs");
Console.WriteLine(res);



// Ex1  Cycle for
/*
for (int i=0; i < count; i++)
{
    result = result + text;
}

*/
//  Ex2 cycle inside cycle 
/*
for (int i = 2; i <=10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
*/
// Ex3 Есть техт, где к заменить на К, с на С, пробелы на _
/*
string text = " привет коллега, как сам?";

// string s = "qwerty"
//             012
// s[3] = r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
        {
            if(text[i] == oldValue) result = result + $"{newValue}";
            else result = result + $"{text[i]}"; 
        }
        return result; 
}

string newText = Replace(text, ' ', '_');

newText = Replace(newText, 'к', 'К');

newText = Replace(newText, 'с', 'С');

Console.WriteLine(newText);
*/ 
// Ex4 Алгоритм сортировки min - max.  

int [] arr = {1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int [] array)
{
    int count = array.Length;

    for (int b=0; b<count; b++);
        {
            Console.Write($"{array[b]}");
        }
        Console.WriteLine(); 
}


void SelectionSort(int [] array)

{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
            {
                if(array[j] < array[minPosition]) minPosition = j;
            }
        //
        //
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary; 
    }

}

PrintArray(arr);
SelectionSort(arr);