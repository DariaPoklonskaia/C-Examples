// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
/*
int SumOfElementsInBetween (int a, int b)
{
    int max = b;
    int min = a;
    if (max < min) 
    {
        int temp = max;
        max = min;
        min = temp;
    }
    
    if (max == min) return max;
    else return min + SumOfElementsInBetween(min + 1, max);
}

Console.WriteLine("Input first integer number");
int userA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second integer number");
int userB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of elements in b/w is " + SumOfElementsInBetween(userA, userB));

*/
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр
/*
int NumberOfDigits(int a)
{
    if (a/10 == 0) return 1;
    else return 1 + NumberOfDigits(a/10);
}

Console.WriteLine("Input first integer number");
int userA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number of digits is " + NumberOfDigits(userA));

*/