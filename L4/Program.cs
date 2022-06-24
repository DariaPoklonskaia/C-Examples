/*
string [,] table = new string [2,5];
table[1,2] = "word";

for (int rows = 0; rows <2; rows++)
{
    for (int columns = 0; columns < 5; columns ++)
    {
        Console.WriteLine($"-{table[rows,columns]}-");
    }
}
*/
//Ex2
/*
int[,] matrix = new int[3,4];
for (int i = 0; i <matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j ++)
    {
        Console.Write($"{matrix[i,j]}");
    }
Console.WriteLine();
}

*/ 

//Ex3 создание матрицы и ее заполнение
/*
void PrintArray(int[,] matr)
{
    for (int i = 0; i <matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j ++)
    {
        Console.Write($"{matr[i,j]}");
    }
Console.WriteLine();
    }
}


void FillArray(int[,] matr)
{
    for (int i = 0; i <matr.GetLength(0); i++)
    {
    for (int j = 0; j < matr.GetLength(1); j ++)
    {
        matr[i,j] = new Random().Next(1,10);
    }
Console.WriteLine();
    }
}

int[,] matrix = new int[3,4];
PrintArray(matrix); 
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
*/

// paint area inside
/*
int[,] pic = new int[,];// не обязательно указывать кол-во строг и столбцов если есть фиксированные данные

void FillImage(int row, int col)
{
    if(pic[row,col]==0)
    {
        pic[row,col] = 1;
        FillImage[row-1, col];
        FillImage[row, col-1];
        FillImage[row + 1, col];
        FillImage[row, col + 1];
    }
}

*/

//Ex5 Calculate x!
/*
double Factorial (int n) //double так как иначе для больших чисел будет переполнение
{
    if(n == 1) return 1;
    else return n*Factorial(n - 1);
}

Console.WriteLine(Factorial(3)); 
*/

//Ex6 последовательность Фибоначчи
// f(1) = 1
// f(2) = 1
//f(n) = f(n-1) +f(n-2)
/*
int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i=1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
}

*/

