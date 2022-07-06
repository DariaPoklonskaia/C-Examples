//Recursion examples
//вывести строку с числами от а до б
/*
string NumbersRec (int a, int b)
{
    if (a<b) return a + " " + NumbersRec(a+1, b);
    else return b + " ";
}

Console.WriteLine(NumbersRec(1,10));

//вывести строку с числами от а до б, а больше б
string NumbersRec(int a, int b)
{
    if (a >= b) return NumbersRec(a-1, b) + $"{a} ";
    else return String.Empty;
}

Console.WriteLine(NumbersRec(10,1));


// сумма цифр от 1 до н
int SumRec(int n)
{
    if (n==1) return 1;
    else return n + SumRec(n-1);
}

Console.WriteLine(SumRec(3));
*/

//factorial n
int FactorialRec(int n) // 0! need to be described here
{
    if (n==1) return 1;
    else return n*FactorialRec(n-1);
}

Console.WriteLine(FactorialRec(4));
