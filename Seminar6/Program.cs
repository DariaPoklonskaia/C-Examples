// Ex1 разворот массива
/*
int[] ReverseArray(int[]array)
{
    int temp; 
    int j = array.Length -1;
    for(int i = 0; i < (array.Length)/2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
        
    }

    //while (i<j) вместо цикла фор, исп цикл while;
  //  {
 //        temp = array[i];
  //      array[i] = array[j];
   //     array[j] = temp;
   //     i++;
  //      j--; 
    //}
    return array;
}

int[] MyArray= {1, 2, 3, 4, 5, 6, 7};
MyArray = ReverseArray(MyArray);
for(int i=0; i <MyArray.Length; i++)
{
    Console.Write(MyArray[i] + " ");
}

*/

//Ex2 программа принимает три часа, и проверяет может ли существовать такой треугольник с такими сторонами. т.е. 
// сумма любых двух сторон должна быть строго больше чем третья.

/*
bool CheckTriangle (int a, int b, int c)
{
   
        return (a + b > c && b + c > a && a+c > b && a > 0 && b>0 && c>0);
    
}


Console.WriteLine("Input natural first number to check if triangle");
int userA= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second natural  number to check if triangle");
int userB= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third natural  number to check if triangle");
int userC= Convert.ToInt32(Console.ReadLine());

bool result = CheckTriangle(userA, userB, userC);
Console.WriteLine(result);

*/

// Ex 3 нерекурсионный метод вывода последовательности фибонначи. пользователь ввоодит число n, и должно быть выведено первые n чисел
/*
int[] Fibonacci(int number)
{ 
    int[] FibArray = new int[number];
    FibArray[0] = 0;
    FibArray[1] = 1;
    for (int i = 2; i < number; i++)
    { 
        FibArray[i] = FibArray[i-1] + FibArray[i-2]; 
    }
    return FibArray;
}

void PrintArray (int[] printArray)
{
    for (int i = 0; i < printArray.Length; i++)
    Console.Write(printArray[i] + " ");
}

Console.WriteLine("Input number of elements to see");
int userNumber= Convert.ToInt32(Console.ReadLine());

PrintArray(Fibonacci(userNumber));

*/

// преобразовать десятичное число в двочное
double Convert10to2(int num)
{
    double result = 0;
    int Quotient = num/2;
    int i = 0;
    while (Quotient != 0)
    {
     Quotient = num/2;
     int residual = num - (Quotient*2);
     result = result + residual*Math.Pow(10, i);
     num = Quotient; 
     i++;
    }
    return result;
}

int UserN = 12; 
Console.WriteLine(Convert10to2(UserN));



// simplera way to convert 10 to 2 
/*
string BinaryNumber(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num%2 + result; // в этом случае не возникает проблем преодразования переменной инт в стринг\. сложнее тоже как нужно проходит
        num /=2;
    }
    return result;
}

Console.WriteLine(BinaryNumber(15));
*/