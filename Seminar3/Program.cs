// Ex 1 Принимает на вход координаты точки [X, y]; нераные нулю. Выдаем четверть в которой находится эта  точка.
/*
int FindQuart (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return -1; 
}

Console.WriteLine("Input non-zero x coordinate");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input non-zero y coordinate");
int y1 = Convert.ToInt32(Console.ReadLine());

int result = FindQuart(x1, y1);

if (result == -1) Console.WriteLine("This point belong to one of the axis");
else Console.WriteLine($"Point related to {result} quard");

*/

// Ex2 по заданной четверти покажет диапозон точек
/* 
void FindRange (int QNumber)
{
    if (QNumber == 1) Console.WriteLine("x > 0 and y > 0");
    if (QNumber == 2) Console.WriteLine("x < 0 and y > 0");
    if (QNumber == 3) Console.WriteLine("x < 0 and y < 0");
    if (QNumber == 4) Console.WriteLine("x > 0 and y < 0");
}

Console.WriteLine("Input quard number");
int UserQnumber = Convert.ToInt32(Console.ReadLine());

if (UserQnumber >= 1 && UserQnumber <= 4)
    {
        FindRange(UserQnumber);
    }
else Console.WriteLine("You need to input quard number from 1-4");
*/ 

//Ex3 Принимает на вход N и выводит квадраты от 1 до N

/*
void SquareN (int num)
{
    if (num > 0)
    {
        int count = 1;
        while (count <= num)
            {
                Console.Write(count*count + " ");
                count++; 
            }
    }
    else Console.WriteLine("This method doesn't work with negative numbers");
}

Console.WriteLine("Input natural number");
int userNum = Convert.ToInt32(Console.ReadLine());

SquareN(userNum);
*/

// Ex 4 Input two points coordinates, return distance

double FindLenght (double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)); 
}

Console.WriteLine("Input x coordinate first point");
double userX1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y coordinate first point");
double userY1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input x coordinate second point");
double userX2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input y coordinate second point");
double userY2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(FindLenght(userX1, userY1, userX2, userY2));


